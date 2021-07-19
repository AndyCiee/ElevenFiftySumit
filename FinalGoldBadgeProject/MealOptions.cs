using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalGoldBadgeProject
{
    public class MealOptions
    {
    public MealOptions() { }

    public MealOptions(Meal mealName, string mealDescription, double mealPrice)
        {
            Meal = mealName;
            MealDescription = mealDescription;
            MealPrice = mealPrice;

        }

   
    public string MealDescription { get; set; }
    public double MealPrice { get; set; }

    public enum Meal
        {
        Kids=1,
        Bigger,
        Chicken,
        Beef,
        Vegan,
        }


    }
}
