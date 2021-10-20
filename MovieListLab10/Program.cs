using System;

namespace MovieListLab10
{
    class Program
    {
        static void Main(string[] args)
        {
            MoviesDatabase MoviesDb = new MoviesDatabase();
            Console.WriteLine("Welcome to the Movie List App");
            Console.WriteLine("-----------------------------");
            MoviesDb.PrintMovies();
            
            

        }
    }
}
