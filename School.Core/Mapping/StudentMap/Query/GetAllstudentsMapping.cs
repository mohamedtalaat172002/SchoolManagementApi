﻿using School.Core.Features.Students.Query.Result;
using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Mapping.StudentMap
{
    public partial class StudentProfile
    {
        public void GetAllstudent()
        {
            CreateMap<Student, GetAllStudentDto>();
               
        }

    }
}
