using ApplicationCore.Entities;
using ApplicationCore.RepositoryContracts;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class CastRpository : ICastRepository
    {
        private readonly MovieShopDbContext _movieShopDbContext;
        public CastRpository(MovieShopDbContext dbContext)
        {
            _movieShopDbContext = dbContext;
        }

        public async Task<Cast> GetById(int id)
        {
            var casts = await _movieShopDbContext.Casts
                .FirstOrDefaultAsync(m => m.Id == id);
            return casts;
        }
    }
}
