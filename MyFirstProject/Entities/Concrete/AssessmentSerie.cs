using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class AssessmentSerie:IEntity
    {
        public int Id { get; set; }
        public int SeriesId { get; set; }
        public int UserId { get; set; }
        public int GenresId { get; set; }
        public string Comment { get; set; }
        public int Point { get; set; }
    }
}
