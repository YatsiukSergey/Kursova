using System;using System.Collections.Generic;
using System.Text;using System.Threading.Tasks;using Library;class Program{       static void Main()    {        Restaurant restaurant = new Restaurant();        restaurant.LoadData();
        PrintMenu(restaurant.Dishes);
        Console.WriteLine("What do you want from the  dishes . If you do not want anything write No ");
        string order;
        double price = 0;
        string Order="";
        double Price=0;
        string portion;
        Order _Order = new Order();
        (string,double) order3;
        order = "-1";
        bool working = true;
        while (working)
        {   
            order = Console.ReadLine();
           if (order == "No")
                {
                    working = false;
                    break;
                }
            Console.WriteLine("how much portion ? ");
            portion = Console.ReadLine();
            
            try
            {
                
                order3 = _Order.Orders(order, price, restaurant.Dishes,portion);
              
                Order += order3.Item1 + " ";
                Price += order3.Item2;
                Console.WriteLine($"Your Order: {Order}");
                Console.WriteLine($"Your Price: {Price}");
                Console.WriteLine("Maybe you want something else?");   
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Enter the dishs again and the number of servings");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Enter the dishs again and the number of servings");
            }
        }
        Console.WriteLine($"Your Order: {Order}");
        Console.WriteLine($"Your Price: {Price}");
    }

    static void PrintMenu(List<Dish> Dishes)    {        for (int i = 0; i < Dishes.Count; i += 2)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Dishes[i].Name,-60} {Dishes[i + 1].Name,-50}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"RECIPE OF: {Dishes[i].Recipe,-50}" + $"RECIPE OF:{Dishes[i + 1].Recipe}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"PRICE DISH:{Dishes[i].Price,-50}" + $"PRICE DISH::{Dishes[i + 1].Price}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }}