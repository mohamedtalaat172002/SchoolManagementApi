using School.Data.Entities;
using School.Infrastructure.Abstracts;
using School.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Service.Implemetation
{
    public class StudentServices : IStudentServices
    {
        private readonly IstudentRepository _studentRepository;

        public StudentServices(IstudentRepository istudentRepository)
        {
            _studentRepository = istudentRepository;
        }
        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            var students= await _studentRepository.GetAllStudents();
            return students;
        }
    }
}
