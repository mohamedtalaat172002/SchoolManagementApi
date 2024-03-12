
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Mapping.StudentMap
{
    public partial class StudentProfile:Profile
    {
        public StudentProfile()
        {
            GetAllstudent();
            GetSingleStudentbyId();
        }
    }
}
