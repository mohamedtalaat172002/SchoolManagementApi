using Microsoft.EntityFrameworkCore;
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

        public StudentServices(IstudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            var students= await _studentRepository.GetAllStudents();
            return students;
        }

        public async Task<Student> GetStudentById(int id)
        {
            var student =_studentRepository.GetTableNoTracking()
                                .Include(d=>d.Department)
                                .Where(c=>c.StudID.Equals(id))
                                .FirstOrDefault();
                                 
            return student;
        }
    }
}
