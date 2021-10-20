using System;
using System.Collections.Generic;
using System.Text;

namespace MovieListLab10
{
    class MoviesDatabase
    {
        
        public List<Movies> MovieLists { get; set; } = new List<Movies>();

        public MoviesDatabase()
        {
            MovieLists.Add(new Movies("Star Wars", "Scifi"));
            MovieLists.Add(new Movies("Tenet", "Scifi"));
            MovieLists.Add(new Movies("Men in Black", "Scifi"));
            MovieLists.Add(new Movies("The Island", "Scifi"));
            MovieLists.Add(new Movies("Ghost in the Shell", "Animated"));
            MovieLists.Add(new Movies("Spirited Away", "Animated"));
            MovieLists.Add(new Movies("Josee, the Tiger and the Fish", "Animated"));
            MovieLists.Add(new Movies("The Enforcer", "Nior"));
            MovieLists.Add(new Movies("Kung Fu Hustle", "Comedy"));
            MovieLists.Add(new Movies("King of Comedy", "Comedy"));

        }
      
        public void PrintMovies()
        {
            for (int i = 0; i < MovieLists.Count; i++)
            {
                Movies m = MovieLists[i];
                Console.WriteLine($"{i}: {m.Name}");
                
            }
        }
        public void AddMovies(string name, string category)
        {
            Movies mdb = new Movies(name, category);

            MovieLists.Add(mdb);
        }
        public string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }

        public void PickOne(int index)
        {
            string pickCategory = GetUserInput("Please pick a category by typing in the following: (scifi, animated, nior, comedy) ");
            pickCategory = pickCategory.ToLower();
            if (pickCategory == "scifi")
            {
                Console.WriteLine("Star Wars", "Tenet", "Men in Black", "The Island");
                string newName = Console.ReadLine();
            }
            else if (pickCategory == "animated")
            {
                Console.WriteLine("Ghost in the Shell", "Spirited Away", "Josee, the Tiger and the Fish");
            }
            else if (pickCategory == "nior")
            {
                Console.WriteLine("The Emforcer");
            }
            else if (pickCategory == "comedy")
            {
                Console.WriteLine("Kung Fu Hustle", "King of Comedy");
            }
            else
            {
                Console.WriteLine("Please select one of the listed categories.");
                
            }
            //char.IsUpper
            //name.SubString(0,1)
            //Tis is for capital letter of the forst letter of a word
        }

            //}
        
    }
}
