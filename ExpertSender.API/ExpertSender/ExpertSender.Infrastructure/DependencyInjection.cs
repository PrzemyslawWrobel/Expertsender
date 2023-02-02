using ExpertSender.Application.Common.Interfaces;
using ExpertSender.Infrastructure.ExternalApi;
using ExpertSender.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSender.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //TODO po implementacji mtody  w TerytClient podać nazwę s klienta http

            //Konfiguracja cklienta http do zewnętrznego api
            //services.AddHttpClient("TerytClient", options =>
            //{ 
            //	options.BaseAddress = new Uri("http://www.example.com");
            //	options.Timeout = new TimeSpan(0, 0, 10);
            //	options.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            //}).ConfigurePrimaryHttpMessageHandler(sp => new HttpClientHandler()) ;
            //services.AddScoped<TerytClient, TerytClient>();
  
            services.AddTransient<IDateTime, DateTimeService>();
            return services;
        }
    }
}
