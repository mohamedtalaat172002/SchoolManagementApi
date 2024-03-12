using AutoMapper;
//using Azure;
using MediatR;
using School.Core.Bases;
using School.Core.Features.Students.Query.Model;
using School.Core.Features.Students.Query.Result;
using School.Data.Entities;
using School.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Students.Query.Hnandler
{
    public class studentQueryHandler :ResponseHandler,
        IRequestHandler<GetStudentListQuery, Response<IEnumerable<GetAllStudentDto>>>,
        IRequestHandler<GetSingleStudentQuery,Response<GetSingleStudentDto>>

    {

        private readonly IStudentServices _studentServices;
        private readonly IMapper _mapper;
        public studentQueryHandler(IStudentServices studentServices,IMapper mapper )
        {
            _studentServices = studentServices; 
            _mapper = mapper;
        }

        public async Task <Response<IEnumerable<GetAllStudentDto>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var students =await _studentServices.GetAllStudents();
            var MappedStudents = _mapper.Map<IEnumerable<GetAllStudentDto>>(students);
            return Success(MappedStudents);
        }

        public async Task<Response<GetSingleStudentDto>> Handle(GetSingleStudentQuery request, CancellationToken cancellationToken)
        {
            var Student = await _studentServices.GetStudentById(request.id);
            var StudentMapped = _mapper.Map<GetSingleStudentDto>(Student);
            return Success(StudentMapped);
        }
    }
}
