using Finexo.Core.Entities;
using Finexo.Core.Entities.BaseEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finexo.Data.Contexts
{
    public class FinexoDbContext : DbContext
    {
        public FinexoDbContext(DbContextOptions options) : base(options)
        {

        }

        DbSet<Customer> Customers { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Position> Positions { get; set; }
        DbSet<Service> Services { get; set; }
        DbSet<Setting> Settings { get; set; }
        DbSet<Slider> Sliders { get; set; }
        DbSet<SocialMedia> SocialMedias { get; set; }
        DbSet<Why> Why { get; set; }

        //dotnet ef --startup-project ..\Finexo.App migrations add Initial
    }
}
