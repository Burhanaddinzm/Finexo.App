using Finexo.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finexo.Core.Entities
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; } = null!;
        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
