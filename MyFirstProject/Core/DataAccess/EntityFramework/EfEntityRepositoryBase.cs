using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    //entity ve context vererek bir base framework oluşturuyoruz
    //DbContext'ten inherit olması lazım TContext'e her şeyi yazamazsın
    
    public class EfEntityRepositoryBase<TEntity,TContext>: IEntityRepository<TEntity>

        where TEntity : class,IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //using içerisine yazılanlar kod çalışıp bittikten sonra garbage collector tarafından silinir. Context nesnesi pahalı olduğu için
            //NorthwindContext işi bitince garbage collector tarafından silinecek.
            //var veri tipi belli değil
            //IDisposable pattern implementation of c#

            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); //veri kaynağım ile ilikşilendirdim bunu (referansı yakala)
                addedEntity.State = EntityState.Added; //veritabanına bu veriyi ekle (bu aslında eklenecek bir nesne)
                context.SaveChanges(); //(ekleme işlemini tamamla)
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public TEntity GetById(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            //tek data getirecek
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            //filtre vermeyedebilir
            //filtre göndermemişse veritabanındaki ilgili tablodaki tüm datayı getir
            //filtre vermiş ise filtreye uygun datayı getir
            //filtre null ise ilk kısım çalışır değil ise ikinci kısım çalışır
            //context.Set<Product> : veritabanında product tablosu ile çalışacağım demek
            //context.Set<Product>().ToList() veritabanındaki tüm tabloyu listeye çevir ve bana ver (arkada select * from products döndürür)
            //filtre null değil ise context.Set<Product>().Where(filter).ToList() filtreyi uygula ve sonucu bana listele
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }


    }
}
