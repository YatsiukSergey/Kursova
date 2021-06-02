using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Restaurant
    {
        public List<Ingrediante> Ingrediantes = new List<Ingrediante>();
        public List<Dish> Dishes = new List<Dish>();


        public void LoadData()
        {
            Ingrediantes.Add(new Ingrediante("chiken"));
            Ingrediantes.Add(new Ingrediante("tomato"));
            Ingrediantes.Add(new Ingrediante("potato"));
            Ingrediantes.Add(new Ingrediante("cheese"));
            Ingrediantes.Add(new Ingrediante("salmon"));
            Ingrediantes.Add(new Ingrediante("onion"));
            Ingrediantes.Add(new Ingrediante("cucamber"));
            Ingrediantes.Add(new Ingrediante("dorado"));
            Ingrediantes.Add(new Ingrediante("oring"));
            Ingrediantes.Add(new Ingrediante("lemon"));
            Ingrediantes.Add(new Ingrediante("beef"));
            Ingrediantes.Add(new Ingrediante("pork"));
            Ingrediantes.Add(new Ingrediante("mushrooms"));
            Ingrediantes.Add(new Ingrediante("apple"));
            Ingrediantes.Add(new Ingrediante("beet"));
            Ingrediantes.Add(new Ingrediante("rise"));
            Ingrediantes.Add(new Ingrediante("pasta"));
            Ingrediantes.Add(new Ingrediante("peper"));
            Ingrediantes.Add(new Ingrediante("zucchine"));
            Ingrediantes.Add(new Ingrediante("coutonos"));
            Ingrediantes.Add(new Ingrediante("olives"));
            Ingrediantes.Add(new Ingrediante("salad"));
            Ingrediantes.Add(new Ingrediante("becon"));
            Ingrediantes.Add(new Ingrediante("water"));

            Dish baked_chiken = new Dish("Baked chiken", 100, new List<Ingrediante>() { Ingrediantes.Find(x => x.Name == "chiken"), 
            Ingrediantes.Find(x => x.Name == "tomato"), Ingrediantes.Find(x => x.Name == "potato"), Ingrediantes.Find(x => x.Name == "cheese") });
            Dish salmon_freee = new Dish("Salmon freee", 200, new List<Ingrediante>() { Ingrediantes.Find(x => x.Name == "salmon"), Ingrediantes.Find(x => x.Name == "lemon"), Ingrediantes.Find(x => x.Name == "tomato"), Ingrediantes.Find(x => x.Name == "cheese") });
            Dish fried_pork_ribs = new Dish(" Fried pork ribs", 150, new List<Ingrediante>() { Ingrediantes.Find(x => x.Name == "pork"), Ingrediantes.Find(x => x.Name == "potato"), Ingrediantes.Find(x => x.Name == "tomato"), Ingrediantes.Find(x => x.Name == "mushrooms") });
            Dish steak = new Dish("Steak", 300, new List<Ingrediante>() { Ingrediantes.Find(x => x.Name == "beef"), Ingrediantes.Find(x => x.Name == "potato"), Ingrediantes.Find(x => x.Name == "onion") });
            Dish baked_dorado = new Dish("Baked dorado", 100, new List<Ingrediante>() { Ingrediantes.Find(x => x.Name == "dorado"), Ingrediantes.Find(x => x.Name == "tomato"), Ingrediantes.Find(x => x.Name == "oring"), Ingrediantes.Find(x => x.Name == "lemon") });
            Dish borsch = new Dish("Borsch", 75, new List<Ingrediante>() { Ingrediantes.Find(x => x.Name == "pork"), Ingrediantes.Find(x => x.Name == "potato"), Ingrediantes.Find(x => x.Name == "onion"), Ingrediantes.Find(x => x.Name == "beet") });
            Dish fish_soup = new Dish("Fish soup", 80, new List<Ingrediante>() { Ingrediantes.Find(x => x.Name == "salmon"), Ingrediantes.Find(x => x.Name == "potato"), Ingrediantes.Find(x => x.Name == "rise"), Ingrediantes.Find(x => x.Name == "lemon") });
            Dish bouillon = new Dish("Bouillon", 60, new List<Ingrediante>() { Ingrediantes.Find(x => x.Name == "chiken"), Ingrediantes.Find(x => x.Name == "pasta"), Ingrediantes.Find(x => x.Name == "onion") });
            Dish grilled_vegetables = new Dish("Grilled vegetables", 90, new List<Ingrediante>() { Ingrediantes.Find(x => x.Name == "tomato"), Ingrediantes.Find(x => x.Name == "peper"), Ingrediantes.Find(x => x.Name == "mushrooms"), Ingrediantes.Find(x => x.Name == "zucchine") });
            Dish potato = new Dish("Potato", 40, new List<Ingrediante>() { Ingrediantes.Find(x => x.Name == "potato") });
            Dish boiled_rise = new Dish("Boiled rise", 40, new List<Ingrediante>() { Ingrediantes.Find(x => x.Name == "rise") });
            Dish vegetable_salad = new Dish("Vegetable salad", 60, new List<Ingrediante>() { Ingrediantes.Find(x => x.Name == "tomato"), Ingrediantes.Find(x => x.Name == "onion"), Ingrediantes.Find(x => x.Name == "peper"), Ingrediantes.Find(x => x.Name == "cucamber") });
            Dish caesar = new Dish("Caesar", 100, new List<Ingrediante>() { Ingrediantes.Find(x => x.Name == "becon"), Ingrediantes.Find(x => x.Name == "cheese"), Ingrediantes.Find(x => x.Name == "tomato"), Ingrediantes.Find(x => x.Name == "salad"), Ingrediantes.Find(x => x.Name == "coutonos"), Ingrediantes.Find(x => x.Name == "chiken") });
            Dish greek_salad = new Dish("Greek salad", 80, new List<Ingrediante>() { Ingrediantes.Find(x => x.Name == "salad"), Ingrediantes.Find(x => x.Name == "tomato"), Ingrediantes.Find(x => x.Name == "cheese"), Ingrediantes.Find(x => x.Name == "onion"), Ingrediantes.Find(x => x.Name == "olives") });
            Dish juice = new Dish("Juice", 30, new List<Ingrediante>() { Ingrediantes.Find(x => x.Name == "apple"), Ingrediantes.Find(x => x.Name == "tomato") });
            Dish compote = new Dish("Compote", 20, new List<Ingrediante>() { Ingrediantes.Find(x => x.Name == "apple") });

            Dishes.Add(baked_chiken);
            Dishes.Add(salmon_freee);
            Dishes.Add(fried_pork_ribs);
            Dishes.Add(steak);
            Dishes.Add(baked_dorado);
            Dishes.Add(borsch);
            Dishes.Add(fish_soup);
            Dishes.Add(bouillon);
            Dishes.Add(grilled_vegetables);
            Dishes.Add(potato);
            Dishes.Add(boiled_rise);
            Dishes.Add(vegetable_salad);
            Dishes.Add(caesar);
            Dishes.Add(greek_salad);
            Dishes.Add(juice);
            Dishes.Add(compote);



        }
        
      



    }
}
