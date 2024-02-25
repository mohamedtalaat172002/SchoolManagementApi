using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Service.Abstracts
{
    internal interface IStudentServices
    {
        Task<IEnumerable<Student>> GetAllStudents();
    }
}
