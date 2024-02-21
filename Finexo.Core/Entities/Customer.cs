using Finexo.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finexo.Core.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Subtitle { get; set; } = null!;
        public string Comment { get; set; } = null!;
        public string Image { get; set; } = null!;
    }
}
