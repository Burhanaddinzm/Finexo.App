using Finexo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finexo.Service.Services.Interfaces
{
    public interface IPositionService
    {
        public Task CreateAsync();
        public Task<IEnumerable<Position>> GetAllAsync();
    }
}
