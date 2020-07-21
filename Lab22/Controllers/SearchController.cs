using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab22.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab22.Controllers
{
    public class SearchController : Controller
    {
        private readonly SearchResult listOfMovies;

        public SearchController()
        {

        }

        private static SearchResult NewMethod()
        {
            return new SearchResult
            {
                MovieList = new List<Movie>() {
                new Movie("The Old Guard", MovieGenre.Action),
                new Movie("365 DNI", MovieGenre.Drama),
                new Movie("Fatal Affair", MovieGenre.Drama),
                new Movie("Platform", MovieGenre.Scifi),
                new Movie("The Gentlemen", MovieGenre.Action),
                new Movie("Extraction", MovieGenre.Action),
                new Movie("The King Of Staten Island", MovieGenre.Comedy),
                new Movie("Ghosts Of War", MovieGenre.Horror),
                new Movie("Easy Does It", MovieGenre.Action),
                new Movie("The Painted Bird", MovieGenre.Drama),
                new Movie("Dirt Music", MovieGenre.Drama),
                new Movie("Nice Girl Like You", MovieGenre.Comedy),
                new Movie("High Life", MovieGenre.Scifi),
                new Movie("Replicas", MovieGenre.Scifi),
                new Movie("Upgrade", MovieGenre.Scifi),
            }
            };
        }

        public IActionResult Index() => View();

        public IActionResult Search() => View();

        [HttpPost]
        public IActionResult SearchResultTitle(string title)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            listOfMovies.SearchTitle(title);

            return View(listOfMovies);
        }

        [HttpPost]
        public IActionResult SearchResultGenre(string genre)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            listOfMovies.SearchGenre(genre);

            return View(listOfMovies);
        }
    }
}
