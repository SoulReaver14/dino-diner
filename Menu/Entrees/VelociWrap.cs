using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class VelociWrap : Entree
    {
        /// <summary>
        /// VelociWrap Constructor
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
            ingredients.Add("Flour Tortilla");
            ingredients.Add("Chicken Breast");
            ingredients.Add("Ceasar Dressing");
            ingredients.Add("Romaine Lettuce");
            ingredients.Add("Parmesan Cheese");
        }

        /// <summary>
        /// Removes dressing from ingredients
        /// </summary>
        public void HoldDressing()
        {
            ingredients.Remove("Ceasar Dressing");
        }

        /// <summary>
        /// Removes lettuce from ingredients
        /// </summary>
        public void HoldLettuce()
        {
            ingredients.Remove("Romaine Lettuce");
        }

        /// <summary>
        /// Removes cheese from ingredients
        /// </summary>
        public void HoldCheese()
        {
            ingredients.Remove("Parmesan Cheese");
        }

        /// <summary>
        /// Override for ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
