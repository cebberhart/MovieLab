using System;
using System.Collections.Generic;
using System.Text;

namespace MovieListLab10
{
    class Movies
    {
        //properties
        public string Name { get; set; }
        public string Category { get; set; }

        //constructor
        public Movies (string Name, string Category)
        {
            this.Name = Name;
            this.Category = Category;

        }


    }
}
