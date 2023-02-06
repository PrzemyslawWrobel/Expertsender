using AutoMapper;
using ExpertSender.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSender.Application.Employees.Queries.GetEmployeeDetail
{
    public class GetEmployeeCommandHandler : IRequestHandler<GetEmployeeCommand, EmployeeVm>
    {
        private readonly IExpertSenderDbContext _expertSenderDbContext;
        private readonly IMapper _mapper;
        public GetEmployeeCommandHandler(IExpertSenderDbContext expertSenderDbContext, IMapper mapper)
        {
            _expertSenderDbContext = expertSenderDbContext;
            _mapper = mapper;
        }

        public async Task<EmployeeVm> Handle(GetEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = _expertSenderDbContext.Employees.Where(d => d.Id == request.EmployeeId)
                .Include(i => i.Department)
                .Include(a => a.Addresses)
                .FirstOrDefaultAsync(cancellationToken);
            var emploeeVm = _mapper.Map<EmployeeVm>(employee);
            return emploeeVm;
        }
    }
}
