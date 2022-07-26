﻿using ApplicationCore.Models;
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

        public async Task<MovieListModel> GetCastDetails(int id)
        {
            var castDetail = await _castRepository.GetById(id);
            var castDetailModel = new MovieListModel();
            foreach (var card in castDetail.MoviesOfCast)
            {
                castDetailModel.lst.Add(new MovieCardModel 
                { 
                    Id = card.MovieId, 
                    Title = card.Movie.Title,
                    PosterUrl = card.Movie.PosterUrl
                });
            }
            return castDetailModel;
            
        }



    }
}

