using ExpertSender.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSender.Application.Employees.Commands.EditEmployeeCommand
{
    public class EditEmployeeCommnadHandler : IRequestHandler<EditEmployeeCommand>
    {
        private readonly IExpertSenderDbContext _expertSenderDbContext;

        public EditEmployeeCommnadHandler(IExpertSenderDbContext expertSenderDbContext)
        {
            _expertSenderDbContext = expertSenderDbContext;
        }

        public async Task<Unit> Handle(EditEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = _expertSenderDbContext.Employees.FirstOrDefault(c => c.Id == request.Id);
            if (employee == null)
            {

            }

            employee.EmployeeName.FirstName = request.FirstName;
            employee.EmployeeName.SecondName = request.SecondName;
            employee.EmployeeName.LastName = request.LastName;
            employee.Email = request.Email;
            employee.DateOfBrith = request.DateOfBrith;
            employee.Gender = request.Gender;
            employee.Department.DepartmentName = request.DepartmentName;
            //employee.Addresses.FirstOrDefault(employee.)




            return Unit.Value;
        }
    }
}
