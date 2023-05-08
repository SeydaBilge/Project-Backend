using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //**generic constraint - generic kısıt
    //class: referans tip olabilir demek
    //IEntity - T bir referans tip olmalı ve T bir IEntity olabilir ya da T, IEntity'den implemente bir nesne olabilir
    //new: new'lenebilir olmalı (IEntity interface olduğu için newlenemez. IEntity'i kısıtımızdan çıkarmak için yazdık)
    public interface IEntityRepository<T> where T: class,IEntity,new()
    {
        //ürün filtresi uygulamak için Expression kullanıyoruz
        //filter=null filtre olmayabilir. Tüm datayı getir şeklinde
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        //tek bir ürünü filtrelemek için expression kullanıyoruz
        //burada filtre zorunlu 
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(Expression<Func<T, bool>> filter);

        //interface metotları default public'tir. (add update Delete)


    }
}

//Core Katmanı diğer katmanları referans almaz
//Core katmanı Northwind'e bağımlı değil
