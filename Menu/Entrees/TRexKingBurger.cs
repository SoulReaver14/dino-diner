using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class TRexKingBurger : Entree
    {

        /// <summary>
        /// Trex King Burger Constructor
        /// </summary>
        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Lettuce");
            ingredients.Add("Onion");
            ingredients.Add("Tomato");
            ingredients.Add("Pickle");
            ingredients.Add("Ketchup");
            ingredients.Add("Mustard");
            ingredients.Add("Mayo");
        }

        /// <summary>
        /// Removes bun from ingredients
        /// </summary>
        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
        }

        /// <summary>
        /// Removes lettuce from ingredients
        /// </summary>
        public void HoldLettuce()
        {
            ingredients.Remove("Lettuce");
        }

        /// <summary>
        /// Removes tomato from ingredients
        /// </summary>
        public void HoldTomato()
        {
            ingredients.Remove("Tomato");
        }

        /// <summary>
        /// Removes pickles from ingredients
        /// </summary>
        public void HoldPickle()
        {
            ingredients.Remove("Pickle");
        }

        /// <summary>
        /// Removes onions from ingredients
        /// </summary>
        public void HoldOnion()
        {
            ingredients.Remove("Onion");
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
        /// Removes mayo from ingredients
        /// </summary>
        public void HoldMayo()
        {
            ingredients.Remove("Mayo");
        }

        /// <summary>
        /// Override for ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}
