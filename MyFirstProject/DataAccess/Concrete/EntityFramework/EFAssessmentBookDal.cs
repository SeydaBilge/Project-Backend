using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFAssessmentBookDal : EfEntityRepositoryBase<AssessmentBook, GeekMatchContext>, IAssessmentBookDal
    {
        public List<AssessmentBookDto> GetAssessmentDetails(int userId,int bookId)
        {
            using (GeekMatchContext context = new GeekMatchContext())
            {
                var result = from a in context.AssessmentBooks
                             join b in context.Books
                             on a.BookId equals b.Id
                             where a.UserId==userId && a.BookId==bookId 
                             select new AssessmentBookDto
                             {
                                 BookName=b.Name,
                                 Comment=a.Comment,
                                 Point=a.Point

                             };

                return result.ToList();
            }
        }
    }
}
