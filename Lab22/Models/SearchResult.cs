using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab22.Models
{
    public class SearchResult
    {
        private readonly MovieGenre a;

        public List<Movie> MovieList { get; set; }
        public string Genre { get; set; }

        public string Title { get; set; }

        public SearchResult(MovieGenre a, List<Movie> movieList, string genre, string title)
        {
            this.a = a;
            MovieList = movieList;
            Genre = genre;
            Title = title;
        }

        public SearchResult()
        {
            MovieList = new List<Movie>();
        }

        public void SearchGenre(string genre)
        {
            var result = new List<Movie>();

            foreach (Movie movie in MovieList)
            {
                if (movie.Genre == a)
                {
                    result.Add(movie);
                }
            }

            MovieList = result;
        }

        public void SearchTitle(string title)
        {
            Title = title;

            var result = new List<Movie>();

            foreach (Movie movie in MovieList)
            {
                if (movie.Title.Contains(title))
                {
                    result.Add(movie);
                }
            }

            MovieList = result;
        }
    }
}
