using ExpertSender.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSender.Persistance
{
    public class ExpertSenderDbContextFactory : DesignTimeDbContextFactoryBase<ExpertSenderDbContext>
    {
        protected override ExpertSenderDbContext CreateNewInstance(DbContextOptions<ExpertSenderDbContext> options)
        {
            return new ExpertSenderDbContext(options);
        }
    }
}
