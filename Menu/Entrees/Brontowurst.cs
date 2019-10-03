using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Brontowurst : Entree
    {

        /// <summary>
        /// Constructor for Brontowurst Menu Item
        /// </summary>
        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;
            ingredients.Add("Brautwurst");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Peppers");
            ingredients.Add("Onion");
        }

        /// <summary>
        /// Method to remove the bun from ingredients
        /// </summary>
        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
        }

        /// <summary>
        /// Method to remove peppers from ingredients
        /// </summary>
        public void HoldPeppers()
        {
            ingredients.Remove("Peppers");
        }

        /// <summary>
        /// Method to remove onions from ingredients
        /// </summary>
        public void HoldOnion()
        {
            ingredients.Remove("Onion");
        }

        /// <summary>
        /// Override for ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
