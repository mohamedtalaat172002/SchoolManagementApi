using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Infrastructure.Abstracts;
using School.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Repositories
{
    public class StudentRepository : IstudentRepository
    {
        
        private readonly DbSet<Student> _students;
         

        public StudentRepository(ApplicationDbContext dbContext ):base()
        {
            _students = dbContext.Set<Student>();
        }


        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await _students.ToListAsync();
                
        }
    }
}
