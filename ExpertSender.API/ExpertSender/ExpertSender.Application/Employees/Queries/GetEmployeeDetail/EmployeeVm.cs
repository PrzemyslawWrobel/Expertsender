using AutoMapper;
using ExpertSender.Application.Common.Interfaces;
using ExpertSender.Domain.Entities;
using ExpertSender.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSender.Application.Employees.Queries.GetEmployeeDetail
{
    public class EmployeeVm : IMapFrom<Employee>
    {
        public int EmployeDetailId { get; set; }
        public string EmployeeFullName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }

        //public string DepartmentName { get; set; }
        //public string AddressType { get; set; }
        //public string Street { get; set; }
        //public string BuildingNumber { get; set; }
        //public string FlatNumber { get; set; }
        //public string ZipCode { get; set; }
        //public string City { get; set; }
        //public string Country { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<Employee, EmployeeVm>(MemberList.None)
                .ForMember(d => d.EmployeeFullName, map => map.MapFrom(src => src.EmployeeName.ToString()))
                .ForMember(d => d.EmployeDetailId, map => map.MapFrom(src => src.Id))
                .ForMember(d => d.Email, map => map.MapFrom(src => src.Email))
                .ForMember(d => d.DateOfBrith, map => map.MapFrom(src => src.DateOfBrith))
                .ForMember(d => d.Gender, map => map.MapFrom(src => src.Gender));
                //.ForMember(d => d.DepartmentName, map => map.MapFrom(src => src.Department.DepartmentName));
            //.ForMember(d => d.AddressType, map => map.MapFrom(src => src.Addresses..AddressType))
            //.ForMember(d => d.Street, map => map.MapFrom(src => src.Street))
            //.ForMember(d => d.BuildingNumber, map => map.MapFrom(src => src.BuildingNumber))
            //.ForMember(d => d.FlatNumber, map => map.MapFrom(src => src.FlatNumber))
            //.ForMember(d => d.ZipCode, map => map.MapFrom(src => src.ZipCode))
            //.ForMember(d => d.City, map => map.MapFrom(src => src.City))
            //.ForMember(d => d.Country, map => map.MapFrom(src => src.Country));
        }
    }
}
