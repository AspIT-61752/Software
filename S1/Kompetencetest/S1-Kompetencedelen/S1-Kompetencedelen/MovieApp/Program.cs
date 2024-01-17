using MovieApp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    internal class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            /*
             * [X] **MovieObject**
             * [X] Create a new Movie object
             * [X] Set the Title, Rating, Director and Year of the movie
             * [X] Add Star Trek Beyond AND Star Wars: Rise of Skywalker to the list of movies
             *
             * [X] **User interaction**
             * [X] Save a new movie to the list of movies
             * [X] Show the list of movies
             * [X] Search for a movie by title
             * [X] End the program
             *
             * [X] **Text/FileHandler**
             * [X] Write the movies to a text file
             * [X] See all the movies in the text file
             * [X] Get the movies from the text file to the movie list
             * [X] Search for a movie by title and show all the movies that match
             *
             * [X] **Misc**
             * [X] Good programming practices
             */

            bool stop = false;
            string userChoice = "";

            List<Movie> Movies = new List<Movie>();
            MovieHandler movieHandler = new MovieHandler(Movies);

            // Handles the user interaction
            while (!stop)
            {
                PrintMenu();
                userChoice = GetUserStringInput("");

                switch (userChoice)
                {
                    case "1":
                        // Show the list of movies
                        PrintMovieList(Movies);
                        Console.Write("\nTryk på en tast for at fortsætte...");
                        Console.ReadKey();
                        break;
                    case "2":
                        // Save a new movie to the list of movies
                        movieHandler.AddNewMovie();
                        break;
                    case "3":
                        // Search for a movie by title
                        Console.Write("\nSkriv titlen på den film du vil søge efter\n > ");
                        movieHandler.SearchMovieByTitle(Console.ReadLine());
                        break;
                    case "4":
                        // Clear the list of movies
                        Movies.Clear();
                        // Get movies from file
                        movieHandler.GetMoviesFromFile();
                        break;
                    case "0":
                        // End the program
                        // Save the movies to the file
                        movieHandler.SaveMovies(Movies);
                        stop = true;
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg");
                        Console.Write("\nTryk på en tast for at fortsætte...");
                        Console.ReadKey();
                        break;
                }
            }
            Console.Write("Programmet er afsluttet. Tryk på en tast for at fortsætte...");
            Console.ReadKey();
        }

        /// <summary>
        /// Prints the menu
        /// </summary>
        static void PrintMenu()
        {
            Console.Clear();

            Console.WriteLine("1. Se alle film");
            Console.WriteLine("2. Tilføj ny film");
            Console.WriteLine("3. Søg efter film");
            Console.WriteLine("4. Hent film fra fil");
            Console.WriteLine("0. Afslut program (Gemmer også film til fil)");
        }

        /// <summary>
        /// Prints the list of movies
        /// </summary>
        /// <param name="movies">The list of movies to print</param>
        static void PrintMovieList(List<Movie> movies)
        {
            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie.GetMovieInfo());
            }
        }

        /// <summary>
        /// Gets the users input
        /// </summary>
        /// <param name="msg">msg added to the console message</param>
        /// <returns>string - The user's input</returns>
        private static string GetUserStringInput(string msg)
        {
            bool valid = false;
            string input = "";

            while (!valid)
            {
                Console.Write("\n{0} > ", msg);
                input = Console.ReadLine();
                if (input != string.Empty && !string.IsNullOrEmpty(input))
                {
                    valid = true;
                }
            }
            return input;
        }
    }
}

