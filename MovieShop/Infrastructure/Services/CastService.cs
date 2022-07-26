using ApplicationCore.Models;
using ApplicationCore.RepositoryContracts;
using ApplicationCore.ServiceContracts;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class CastService : ICastService
    {
        private readonly ICastRepository _castRepository;
        public CastService(ICastRepository movieRepository)
        {
            _castRepository = movieRepository;
        }

        public Task<List<CastModel>> GetCastDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CastModel>> GetCastDetails()
        {
            throw new NotImplementedException();
        }


    }
}

