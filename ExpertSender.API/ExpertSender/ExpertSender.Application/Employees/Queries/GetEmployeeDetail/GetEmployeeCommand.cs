using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSender.Application.Employees.Queries.GetEmployeeDetail
{
    public class GetEmployeeCommand : IRequest<EmployeeVm>
    {
        public int EmployeeId { get; set; }
    }
}
