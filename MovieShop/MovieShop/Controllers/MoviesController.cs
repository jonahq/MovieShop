using ApplicationCore.ServiceContracts;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly ICastService _castService;

        public MoviesController(IMovieService movieService, ICastService castService)
        {
            _movieService = movieService;
            _castService = castService;
        }

        [HttpGet]
        public async Task< IActionResult> Details(int id)
        {
            var movieDetails = await _movieService.GetMovieDetails(id);
            return View(movieDetails);
        }

        [HttpGet]
        public async Task<IActionResult> Purchase(int id)
        {
            var movieDetails = await _movieService.GetMovieDetails(id);
            return View(movieDetails);
        }

        [HttpGet]
        public async Task<IActionResult> CastDetail(int id)
        {
            var castDetails = await _castService.GetCastDetails(id);
            return View(castDetails);
        }

    }
}
