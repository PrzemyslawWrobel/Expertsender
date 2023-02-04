using ExpertSender.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSender.Application.Common.Interfaces
{
    public interface IExpertSenderDbContext
    {
        DbSet<Employee> Employees { get; set; }
        DbSet<Address> Addresses { get; set; }
        DbSet<Department> Departments { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
