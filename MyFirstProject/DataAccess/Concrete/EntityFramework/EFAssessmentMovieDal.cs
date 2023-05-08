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
    public class EFAssessmentMovieDal : EfEntityRepositoryBase<AssessmentMovie, GeekMatchContext>, IAssessmentMovieDal
    {
        public List<AssessmentMovieDto> GetAssessmentDetails(int userId, int movieId)
        {
            using (GeekMatchContext context = new GeekMatchContext())
            {
                var result = from a in context.AssessmentMovies
                             join b in context.Movies
                             on a.MovieId equals b.Id
                             join g in context.Genres
                             on a.GenresId equals g.Id
                             where a.UserId == userId && a.MovieId == movieId
                             select new AssessmentMovieDto
                             {
                                 MovieName = b.Name,
                                 Comment = a.Comment,
                                 Point = a.Point,
                                 GenreName=g.Name

                             };

                return result.ToList();
            }
        }

    }
}
