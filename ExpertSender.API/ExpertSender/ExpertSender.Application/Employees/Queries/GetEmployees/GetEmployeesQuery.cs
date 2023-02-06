using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSender.Application.Employees.Queries.GetEmployees
{
    public class GetEmployeesQuery : IRequest<EmployeesVm>
    {
    }
}
