﻿using ApplicationCore.ServiceContracts;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using MovieShop.Models;
using System.Diagnostics;

namespace MovieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMovieService _movieService;

        public HomeController(ILogger<HomeController> logger, IMovieService movieService)
        {
            _logger = logger;
            _movieService = movieService;

        }

        public async Task<IActionResult> Index()
        {
            var movieCards = await _movieService.GetTopRevenueMovies();
            return View(movieCards);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}