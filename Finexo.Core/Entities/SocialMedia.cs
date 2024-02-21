using Finexo.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finexo.Core.Entities
{
    public class SocialMedia : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Image { get; set; } = null!;
        public string Url { get; set; } = null!;
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
