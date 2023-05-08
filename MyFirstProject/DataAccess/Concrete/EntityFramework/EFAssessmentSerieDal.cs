using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFAssessmentSerieDal : EfEntityRepositoryBase<AssessmentSerie, GeekMatchContext>, IAssessmentSeriesDal
    {
        public List<AssessmentSerieDto> GetAssessmentDetails(int userId, int seriesId)
        {
            using (GeekMatchContext context = new GeekMatchContext())
            {
                var result = from a in context.AssessmentSeries
                             join b in context.Series
                             on a.SeriesId equals b.Id
                             join g in context.Genres
                             on a.GenresId equals g.Id
                             where a.UserId == userId && a.SeriesId == seriesId
                             select new AssessmentSerieDto
                             {
                                 SeriesName = b.Name,
                                 Comment = a.Comment,
                                 Point = a.Point,
                                 GenreName = g.Name

                             };

                return result.ToList();
            }
        }
    }
}
