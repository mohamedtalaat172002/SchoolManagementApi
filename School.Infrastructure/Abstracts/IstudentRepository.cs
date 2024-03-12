using School.Data.Entities;
using School.Infrastructure.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Abstracts
{
    public interface IstudentRepository: IGenericRepositoryAsync<Student>
    {
        Task<IEnumerable<Student>> GetAllStudents();
    }
}
