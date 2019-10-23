using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/* Brontowurst.cs
 * Author: Anthony Garvalena
 */

namespace DinoDiner.Menu
{
    public class Brontowurst : Entree, INotifyPropertyChanged
    {
        //Backing Variables
        private bool bun = true;
        private bool peppers = true;
        private bool onion = true;
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
            bun = false;
            ingredients.Remove("Whole Wheat Bun");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method to remove peppers from ingredients
        /// </summary>
        public void HoldPeppers()
        {
            peppers = false;
            ingredients.Remove("Peppers");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Method to remove onions from ingredients
        /// </summary>
        public void HoldOnion()
        {
            onion = false;
            ingredients.Remove("Onion");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Override for ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Brontowurst";
        }

        /// <summary>
        /// Returns a string[] that contains strings pertaining to special things to remove or add to the dish.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun) special.Add("Hold Whole Wheat Bun");
                if (!onion) special.Add("Hold Onion");
                if (!peppers) special.Add("Hold Peppers");
                return special.ToArray();
            }
        }
    }
}
