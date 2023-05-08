
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    //bir veritabanı tablosu değil. Birden fazla tablonun join'lenmiş hali
    //Ientity bu bir veritabanı tablosu demekti

    public class ProductDetailDto : IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }

    }
}

