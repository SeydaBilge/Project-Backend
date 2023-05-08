using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        //category ile ilgili dış dünyaya neleri servis etmek istiyosak onları yazıyoruz
        List<Category> GetAll();
        List<Category> GetByCategoryId(int categoryId);


    }
}
