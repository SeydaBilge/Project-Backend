using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public  class AssessmentBook:IEntity
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public int WriterId { get; set; }
        public string Comment { get; set; }
        public int Point { get; set; }
    }
}
