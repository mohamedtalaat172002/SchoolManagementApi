
using MediatR;
using School.Core.Bases;
using School.Core.Features.Students.Query.Result;
using School.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Students.Query.Model
{
    public class GetStudentListQuery:IRequest<Response<IEnumerable<GetAllStudentDto>>>
    {
    }
}
