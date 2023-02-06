using AutoMapper;
using ExpertSender.Application.Common.Interfaces;
using ExpertSender.Domain.Entities;
using ExpertSender.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSender.Application.Employees.Queries.GetEmployees
{
    public class EmployeeDto : IMapFrom<Employee>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBrith { get; set; }
        public string Gender { get; set; }
        public string DepartmentName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Employee, EmployeeDto>(MemberList.None)
                .ForMember(d => d.FirstName, map => map.MapFrom(src => src.EmployeeName.FirstName))
                .ForMember(d => d.LastName, map => map.MapFrom(src => src.EmployeeName.LastName))
                .ForMember(d => d.Email, map => map.MapFrom(src => src.Email))
                .ForMember(d => d.DateOfBrith, map => map.MapFrom(src => src.DateOfBrith))
                .ForMember(d => d.Gender, map => map.MapFrom(src => src.Gender));
            profile.CreateMap<Department, EmployeeDto>(MemberList.None)
                .ForMember(d => d.DepartmentName, map => map.MapFrom(src => src.DepartmentName));
        }
    }
}
