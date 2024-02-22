using Finexo.Data.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finexo.Data.ServiceRegistirations
{
    public static class DataLayerServiceRegisterations
    {
        public static void AddDataLayerServiceRegistiration(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<FinexoDbContext>(opt =>
            opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"),
            cfg =>
             {
                 cfg.MigrationsHistoryTable("Migrations");
             }
        ));
        }
    }
}