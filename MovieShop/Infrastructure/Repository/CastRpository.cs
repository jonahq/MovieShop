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

        public async Task<List<Movie>> GetById(int id)
        {
            var movies = await _movieShopDbContext.Movies.OrderByDescending(m => m.Id).ToListAsync();
            return movies;
        }
    }
}
