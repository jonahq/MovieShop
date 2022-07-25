﻿using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceContracts
{
    public interface IMovieService
    {
        Task<List<MovieCardModel>> GetTopRevenueMovies();
        Task<MovieDetailsModel> GetMovieDetails(int movieId);
    }
}
