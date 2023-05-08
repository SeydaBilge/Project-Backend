using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAssessmentBookService
    {
        IDataResult<List<AssessmentBook>> GetAll();
        IDataResult<List<AssessmentBookDto>> GetById(int userId,int bookId);
        IDataResult<AssessmentBook> Add(AssessmentBook assessmentBook);
        IDataResult<AssessmentBook> Update(AssessmentBook assessmentBook);
        IDataResult<AssessmentBook> Delete(AssessmentBook assessmentBook);

    }
}
