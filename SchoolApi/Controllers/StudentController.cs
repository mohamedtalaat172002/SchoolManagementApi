using MediatR;
using Microsoft.AspNetCore.Mvc;
using School.Core.Features.Students.Query.Model;
using School.Data.AppMetaData;

namespace SchoolApi.Controllers
{
    //"api/[controller]"
    [Route("")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Getallstudents()
        {
            var students = await _mediator.Send(new GetStudentListQuery());
            return Ok(students);
        }

        //[HttpGet(Router.StudentRouting.GetByID)]
        [HttpGet(Router.StudentRouting.GetByID)]
        public async Task<IActionResult> GetStudentbyId([FromRoute]int id )
        {
            var student = await _mediator.Send(new GetSingleStudentQuery(id));
            return Ok(student);
        }


    }
}
