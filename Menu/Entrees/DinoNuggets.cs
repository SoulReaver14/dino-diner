using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree
    {

        /// <summary>
        /// DinoNuggets Constructor
        /// </summary>
        public DinoNuggets()
        {
            Price = 4.25;
            Calories = 354;
            for (int i = 0; i < (6); i++)
            {
                ingredients.Add("Chicken Nugget");
            }
        }

        /// <summary>
        /// Method to add a Chicken Nugget to the ingredients
        /// </summary>
        public void AddNugget()
        {
            ingredients.Add("Chicken Nugget");
            Price += .25;
            Calories += 59;
        }

        /// <summary>
        /// Override for ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }


    }
}
