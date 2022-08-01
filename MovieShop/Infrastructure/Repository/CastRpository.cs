using ApplicationCore.Entities;
using ApplicationCore.RepositoryContracts;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
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
            var movieid = await _movieShopDbContext.Casts
                .Include(m => m.MoviesOfCast).ThenInclude(m => m.Movie)
                .FirstOrDefaultAsync(m => m.Id == id);
            return movieid;
        }
    }
}
