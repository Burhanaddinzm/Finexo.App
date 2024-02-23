using Finexo.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finexo.Core.Entities
{
    public class Position : BaseEntity
    {
        public string Name { get; set; } = null!;
        public HashSet<Employee> Employees { get; set; }
        public Position()
        {
            Employees = new HashSet<Employee>();
        }
    }
}
