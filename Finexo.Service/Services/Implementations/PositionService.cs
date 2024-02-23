using Finexo.Core.Entities;
using Finexo.Data.Contexts;
using Finexo.Service.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finexo.Service.Services.Implementations
{
    public class PositionService : IPositionService
    {
        readonly FinexoDbContext _context;

        public PositionService(FinexoDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync()
        {
            //await _context.Positions.AddAsync();
            //await _context.Positions.AddRangeAsync();
            //await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Position>> GetAllAsync()
        {
            IEnumerable<Position> positions =
                 await _context.Positions.Where(m => !m.IsDeleted)
                 .AsNoTracking().ToListAsync();

            return positions;
        }
    }
}
