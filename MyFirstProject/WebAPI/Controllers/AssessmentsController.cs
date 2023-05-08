using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssessmentsController : Controller
    {
        IAssessmentBookService _assessmentBookService;
        public AssessmentsController(IAssessmentBookService assessmentBookService)
        {
            _assessmentBookService = assessmentBookService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult Add(AssessmentBook assessmentBook)
        {
            var result = _assessmentBookService.Add(assessmentBook);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(AssessmentBook assessmentBook)
        {
            var result = _assessmentBookService.Delete(assessmentBook);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(AssessmentBook assessmentBook)
        {
            var result = _assessmentBookService.Update(assessmentBook);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getid")]
        public IActionResult GetId(int userId , int bookId)
        {
            var result = _assessmentBookService.GetById(userId,bookId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
