using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Order

    {

        public (string, double) Orders(string order, double price, List<Dish> Dishes,string portion)
        {
            int Portion;
            Dish counter;
            string order3 = "";
            (string, double) tuple = ("", 0);
            for (int i = 0; i < Dishes.Count; i++)
            {
                if (order == Dishes[i].Name)
                {
                    counter = Dishes[i];
                    if (Int32.TryParse(portion, out Portion)){
                        if (Convert.ToInt32(portion) > 0)
                        {
                            price = price + Dishes[i].Price * Convert.ToInt32(portion);
                            order3 = order3 + Convert.ToString(portion) + " " + order + ";";
                            tuple = (order3, price);

                        }

                        else if (Convert.ToInt32(portion) <= 0)
                        {
                            throw new ArgumentException("Enter a positive number of servings");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Incorrect input");
                    }
                   
                        return tuple;
                }
                if (i == Dishes.Count - 1) 
                     
                    {
                        throw new ArgumentException("There is no such dish");
                    }
                
            }
            return(null,0);
        }
    }





    }



