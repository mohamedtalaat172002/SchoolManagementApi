using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Abstracts
{
    public interface IstudentRepository
    {
        Task<IEnumerable<Student>> GetAllStudents();
    }
}
