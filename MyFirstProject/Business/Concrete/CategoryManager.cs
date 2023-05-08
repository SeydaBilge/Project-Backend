using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        //iş kodları
        //bağımlılığı constructor injection ile yapıyoruz

        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            //ben kategori olarak veri erişim katmanına bağımlıyım ama biraz zayıf bir bağımlılığım var. Çünkü ben iterface üzerinden referans üzerinden bağımlıyım. O yüzden dataaccess katmanında istediğin gibi işlem yapabilirsin  
            
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }


        //select * from Categories where CategoryId = 3
        public List<Category> GetByCategoryId(int categoryId)
        {
            return _categoryDal.GetAll(c => c.Id == categoryId);
        }


       


    }
}
