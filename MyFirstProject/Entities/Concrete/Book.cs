﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Book:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WriterId { get; set; }
        public string CategoryId { get; set; }
    }
}
