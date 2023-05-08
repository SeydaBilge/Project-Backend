using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AssessmentBookManager : IAssessmentBookService
    {
        IAssessmentBookDal _assessmentBookDal;

        public AssessmentBookManager(IAssessmentBookDal assessmentBookDal)
        {
            _assessmentBookDal = assessmentBookDal;
        }
        public IDataResult<AssessmentBook> Add(AssessmentBook assessmentBook)
        {
            _assessmentBookDal.Add(assessmentBook);
            return new SuccessDataResult<AssessmentBook>(assessmentBook, Messages.AssessmentBookAddSuccess);
        }

        public IDataResult<AssessmentBook> Delete(AssessmentBook assessmentBook)
        {
            _assessmentBookDal.Delete(assessmentBook);
            return new SuccessDataResult<AssessmentBook>(assessmentBook, Messages.AssessmentBookDeleteSuccess);

        }

        public IDataResult<List<AssessmentBook>> GetAll()
        {
            return new SuccessDataResult<List<AssessmentBook>>(_assessmentBookDal.GetAll());
        }

        public IDataResult<List<AssessmentBookDto>> GetById(int userId,int bookId)
        {
            return new SuccessDataResult<List<AssessmentBookDto>>(_assessmentBookDal.GetAssessmentDetails(userId,bookId));
        }

        public IDataResult<AssessmentBook> Update(AssessmentBook assessmentBook)
        {
            _assessmentBookDal.Update(assessmentBook);
            return new SuccessDataResult<AssessmentBook>(assessmentBook, Messages.AssessmentBookUpdateSuccess);

        }
    }
}
