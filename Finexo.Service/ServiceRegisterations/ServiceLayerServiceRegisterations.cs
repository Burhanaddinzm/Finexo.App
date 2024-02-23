using Finexo.Data.Contexts;
using Finexo.Service.Services.Implementations;
using Finexo.Service.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finexo.Service.ServiceRegisterations
{
    public static class ServiceLayerServiceRegisterations
    {
        public static void AddServiceLayerServiceRegisteration(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IPositionService, PositionService>();

            //builder.Services.AddSingleton<IPositionService, PositionService>();
            //builder.Services.AddTransient<IPositionService, PositionService>();
        }
    }
}