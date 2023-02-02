using ExpertSender.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSender.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ExpertSenderDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ExpertSenderApiDatabase")));
            services.AddScoped<IExpertSenderDbContext, ExpertSenderDbContext>();
            return services;
        }
    }
}