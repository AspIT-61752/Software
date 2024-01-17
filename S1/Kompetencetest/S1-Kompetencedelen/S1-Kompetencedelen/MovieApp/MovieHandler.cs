using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    /// <summary>
    /// Does everything related to movies (adding, removing, searching, etc.)
    /// </summary>
    public class MovieHandler
    {
        private List<Movie> Movies { get; set; }

        private FileHandler fileHandler = new FileHandler();

        public MovieHandler(List<Movie> movies)
        {
            Movies = movies;
            movies.Add(new Movie("Star Trek Beyond", 2016, "Justin Lin", "Paramount Pictures"));
            movies.Add(new Movie("Star Wars: Rise of Skywalker", 2019, "J.J. Abrams", "Lucasfilm Ltd."));
        }

        /// <summary>
        /// Adds a new movie to the list of movies
        /// </summary>
        public void AddNewMovie()
        {
            // Handle user input and save it to a new movie object
            Movie movie = new Movie();

            // Get user input for the new movie object
            movie.Title = GetUserStringInput("titel");
            movie.ReleaseYear = GetUserIntInput("udgivelsesår");
            movie.Director = GetUserStringInput("instruktør");
            movie.Studio = GetUserStringInput("studie");

            // Add the new movie to the list of movies
            Movies.Add(movie);
        }

        /// <summary>
        /// Saves the movies from the list to a text file (WILL OVERWRITE EVERYTHING INSIDE THE FILE)
        /// </summary>
        /// <param name="movies">The list of movies that the user wants to save to the file</param>
        public void SaveMovies(List<Movie> movies)
        {
            bool firstLine = true;
            string path = fileHandler.getFilepath();

            foreach (Movie movie in movies)
            {
                // Check if it's the first line, if it is, overwrite the file, else append to the file
                if (firstLine)
                {
                    fileHandler.WriteTextToFile(path, movie.ToString());
                    firstLine = false;
                }
                else
                {
                    fileHandler.WriteTextToFile_Append(path, movie.ToString());
                }
            }

            Console.WriteLine("SaveMovie: {0}", Movies.Count()); // Debug, remove later
        }

        // Could also be in the FileHandler class, but it does make sense to have it here (IMO*)
        /// <summary>
        /// Gets the movies from the text file to the movie list
        /// </summary>
        public void GetMoviesFromFile()
        {
            // Get the filepath from the user
            string path = fileHandler.getFilepath();

            // Read all the lines from the file and loop through them
            // Split each line by ',' and save it to a string array
            // Create a new movie object with the info from the string array 
            // and add it to the list of movies
            string[] allMovies = File.ReadAllLines(path);
            foreach (string movie in allMovies)
            {
                string[] movieInfo = movie.Split(',');
                Movies.Add(new Movie(movieInfo[0], int.Parse(movieInfo[1]), movieInfo[2], movieInfo[3]));
            }
        }

        /// <summary>
        /// Seraches for a movie by title and shows all the movies that match
        /// </summary>
        /// <param name="userQWERY">The user's search "query"</param>
        public void SearchMovieByTitle(string userQWERY)
        {
            // Make the user's search ""query" lowercase
            userQWERY = userQWERY.ToLower();

            Console.Clear();

            // Loop through all the movies and check if the title contains the user's search "query"
            // If it does, print the movie's info
            foreach (Movie movie in Movies)
            {
                if (movie.Title.ToLower().Contains(userQWERY))
                {
                    Console.WriteLine(movie.GetMovieInfo());
                }
            }

            Console.Write("\nTryk på en tast for at fortsætte...");
            Console.ReadKey();
        }

        /// <summary>
        /// Gets the users input
        /// </summary>
        /// <param name="msg">msg added to the console message</param>
        /// <returns>string - The user's input</returns>
        private string GetUserStringInput(string msg)
        {
            bool valid = false;
            string input = "";

            // While the user's input is empty, keep asking for input
            while (!valid)
            {
                Console.Write("\nSkriv {0} her: ", msg);
                input = Console.ReadLine();
                if (input != string.Empty && !string.IsNullOrEmpty(input))
                {
                    valid = true;
                }
            }
            return input;
        }

        /// <summary>
        /// Gets the users input
        /// </summary>
        /// <param name="msg">msg added to the console message</param>
        /// <returns>int - The user's input</returns>
        private int GetUserIntInput(string msg)
        {
            bool valid = false;
            int input = 0;

            // While the user's input isn't an int, keep asking for input
            while (!valid)
            {
                Console.Write("\nSkriv {0} her: ", msg);
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    valid = true;
                }
            }
            return input;
        }
    }
}
