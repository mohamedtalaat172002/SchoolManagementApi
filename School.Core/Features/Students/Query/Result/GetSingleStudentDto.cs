using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Students.Query.Result
{
    public class GetSingleStudentDto
    {
        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? Phone { get; set; }

        public string? DeptName { get; set; }
    }
}
