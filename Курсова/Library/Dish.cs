using System;
using System.Collections.Generic;


namespace Library
{
    public class Dish

    {
        public string Name;
        public string Recipe;
        public double Price;
        public List<Ingrediante> Ingrediantes;
       

        public Dish(string name, double price, List<Ingrediante> ingrediantes)
        {
            Name = name;
            Price = price;
            Ingrediantes = ingrediantes;
            Recipe = "";
            foreach (var ingrediante in ingrediantes)
            {
                Recipe += " " + ingrediante.Name;

            }

        }

       

    }
}
