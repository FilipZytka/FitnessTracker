using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FitnessTracker.Infrastracture.Database;
using Microsoft.EntityFrameworkCore;
using FitnessTracker.Infrastracture.Data_Seeders;
using FitnessTracker.Entities.Interfaces;
using FitnessTracker.Infrastracture.Logs;

namespace FitnessTracker.Infrastracture.Extension
{
    public static class ServiceCollectionExtension
    {
        public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FitnessTrackerDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("FitnessTrackerConnectionString")));

            services.AddScoped<FitnessTrackerSeeder>();

            services.AddScoped<IFitnessLog, FitnessLog>();
        
        
        }
    }
}
