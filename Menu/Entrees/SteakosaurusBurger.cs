using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// Constructor for Steakosaurus Burger
        /// </summary>
        public SteakosaurusBurger()
        {
            Price = 5.15;
            Calories = 621;
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Pickle");
            ingredients.Add("Ketchup");
            ingredients.Add("Mustard");
        }

        /// <summary>
        /// Removes bun from ingredients
        /// </summary>
        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
        }

        /// <summary>
        /// Removes pickles from ingredients
        /// </summary>
        public void HoldPickle()
        {
            ingredients.Remove("Pickle");
        }

        /// <summary>
        /// Removes ketchup from ingredients
        /// </summary>
        public void HoldKetchup()
        {
            ingredients.Remove("Ketchup");
        }

        /// <summary>
        /// Removes mustard from ingredients
        /// </summary>
        public void HoldMustard()
        {
            ingredients.Remove("Mustard");
        }

        /// <summary>
        /// Override for ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
