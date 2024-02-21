using Finexo.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finexo.Core.Entities
{
    public class Setting
    {
        public string AboutDescription { get; set; } = null!;
        public string AboutTitle { get; set; } = null!;
        public string AboutImage { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string Number { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string InfoDescription { get; set; } = null!;
    }
}
