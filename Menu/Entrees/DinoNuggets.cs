using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets : Entree
    {

        public DinoNuggets()
        {
            Price = 4.25;
            Calories = 354;
            for (int i = 0; i < (6); i++)
            {
                ingredients.Add("Chicken Nugget");
            }
        }

        public void AddNugget()
        {
            ingredients.Add("Chicken Nugget");
            Price += .25;
            Calories += 59;
        }


    }
}
