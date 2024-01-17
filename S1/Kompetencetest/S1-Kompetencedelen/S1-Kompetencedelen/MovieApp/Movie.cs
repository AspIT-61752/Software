using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    public class Movie
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Director { get; set; }
        public string Studio { get; set; }

        /// <summary>
        /// Parameterized Constructor for the Movie class
        /// </summary>
        /// <param name="title"></param>
        /// <param name="releaseYear"></param>
        /// <param name="director"></param>
        /// <param name="studio"></param>
        public Movie(string title, int releaseYear, string director, string studio)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Director = director;
            Studio = studio;
        }

        /// <summary>
        /// Empty constructor for the Movie class
        /// </summary>
        public Movie()
        {
            
        }

        /// <summary>
        /// Gets the movie info as a string (For displaying in the console)
        /// </summary>
        /// <returns>string - Movie info</returns>
        public string GetMovieInfo()
        {
            return $"{Title} ({ReleaseYear}) - {Director} - {Studio}";
        }

        /// <summary>
        /// Get the movie info as a string (For saving to a file)
        /// </summary>
        /// <returns>string - Movie info</returns>
        public override string ToString()
        {
            return $"{Title},{ReleaseYear},{Director},{Studio}";
        }
    }
}
