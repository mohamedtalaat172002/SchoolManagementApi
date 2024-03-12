using MediatR;
using School.Core.Bases;
using School.Core.Features.Students.Query.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Students.Query.Model
{
    public class GetSingleStudentQuery:IRequest<Response<GetSingleStudentDto>>
    {
        public int id { get; set; }
        public GetSingleStudentQuery(int id)
        {
            this.id = id;
        }
    }
}
