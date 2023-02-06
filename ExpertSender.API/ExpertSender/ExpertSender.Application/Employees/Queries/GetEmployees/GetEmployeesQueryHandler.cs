using AutoMapper;
using AutoMapper.QueryableExtensions;
using ExpertSender.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSender.Application.Employees.Queries.GetEmployees
{
    public class GetEmployeesQueryHandler : IRequestHandler<GetEmployeesQuery, EmployeesVm>
    {
        private readonly IMapper _mapper;
        private readonly IExpertSenderDbContext _expertSenderDbContext;

        public GetEmployeesQueryHandler(IMapper mapper, IExpertSenderDbContext expertSenderDbContext)
        {
            _mapper = mapper;
            _expertSenderDbContext = expertSenderDbContext;
        }

        public async Task<EmployeesVm> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var employees = await _expertSenderDbContext.Employees.ProjectTo<EmployeeDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
                if (employees == null)
                {
                    //TODO Customexception
                }
                return new EmployeesVm { Employees = employees };
            }
            catch (Exception) 
            {
                throw;
            }
        }
    }
}
