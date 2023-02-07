using ExpertSender.Application.Common.Interfaces;
using ExpertSender.Domain.Entities;
using ExpertSender.Domain.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSender.Application.Employees.Commands.CreateEmployee
{
    internal class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, int>
    {
        private readonly IExpertSenderDbContext _expertSenderDbContext;
        public  CreateEmployeeCommandHandler(IExpertSenderDbContext expertSenderDbContext)
        {
            _expertSenderDbContext = expertSenderDbContext;
        }
        public async Task<int> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            Employee employee = new Employee()
            {
                EmployeeName = new EmployeeName()
                {
                    FirstName = request.FirstName,
                    SecondName = request.SecondName,
                    LastName = request.LastName
                },
                Email = request.Email,
                DateOfBrith = request.DateOfBrith,
                Gender = request.Gender,
               
            };
            _expertSenderDbContext.Employees.AddAsync(employee, cancellationToken);

            //Department department = new Department()
            //{
            //    DepartmentName = request.DepartmentName
            //};
            //_expertSenderDbContext.Departments.AddAsync(department, cancellationToken);

            Address address = new Address()
            {
                AddressType = request.AddressType,
                Street = request.Street,
                BuildingNumber = request.BuildingNumber,
                FlatNumber = request.FlatNumber,
                ZipCode = request.ZipCode,
                City = request.City,
                Country = request.Country
            };
            _expertSenderDbContext.Addresses.AddAsync(address, cancellationToken);
            await _expertSenderDbContext.SaveChangesAsync(cancellationToken);
            return employee.Id;
        }
    }
}
