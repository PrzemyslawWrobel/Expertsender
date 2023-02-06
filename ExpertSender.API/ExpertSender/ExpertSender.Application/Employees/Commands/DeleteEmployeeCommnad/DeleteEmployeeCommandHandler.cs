using ExpertSender.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSender.Application.Employees.Commands.DeleteEmployeeCommnad
{
    internal class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand>
    {
        private readonly IExpertSenderDbContext _expertSenderDbContext;
        
        public DeleteEmployeeCommandHandler(IExpertSenderDbContext expertSenderDbContext) 
        {
            _expertSenderDbContext = expertSenderDbContext;
        }

        public async Task<Unit> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _expertSenderDbContext.Employees.Where(p => p.Id == request.EmployeeId).FirstOrDefaultAsync(cancellationToken);
            _expertSenderDbContext.Employees.Remove(employee);

            await _expertSenderDbContext.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
