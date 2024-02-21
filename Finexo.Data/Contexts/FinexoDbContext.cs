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
    }
}
