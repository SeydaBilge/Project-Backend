using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class AssessmentMovieDto : IDto
    {
        public string MovieName { get; set; }
        public string GenreName { get; set; }
        public string Comment { get; set; }
        public int Point { get; set; }
    }
}
