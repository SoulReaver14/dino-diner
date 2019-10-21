using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/* TRexKingBurger.cs
 * Author: Anthony Garvalena
 */

namespace DinoDiner.Menu
{
    public class TRexKingBurger : Entree, INotifyPropertyChanged
    {

        //Backing Variables
        private bool bun = true;
        private bool lettuce = true;
        private bool onion = true;
        private bool tomato = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

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
        /// An event handler for PropertyChanged events for Price, Calories, and Specials
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Removes bun from ingredients
        /// </summary>
        public void HoldBun()
        {
            bun = false;
            ingredients.Remove("Whole Wheat Bun");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes lettuce from ingredients
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
            ingredients.Remove("Lettuce");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes tomato from ingredients
        /// </summary>
        public void HoldTomato()
        {
            tomato = false;
            ingredients.Remove("Tomato");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes pickles from ingredients
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
            ingredients.Remove("Pickle");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes onions from ingredients
        /// </summary>
        public void HoldOnion()
        {
            onion = false;
            ingredients.Remove("Onion");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes ketchup from ingredients
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;
            ingredients.Remove("Ketchup");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes mustard from ingredients
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
            ingredients.Remove("Mustard");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes mayo from ingredients
        /// </summary>
        public void HoldMayo()
        {
            mayo = false;
            ingredients.Remove("Mayo");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Override for ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
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
                if (!lettuce) special.Add("Hold Lettuce");
                if (!onion) special.Add("Hold Onion");
                if (!tomato) special.Add("Hold Tomato");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if (!mayo) special.Add("Hold Mayo");
                return special.ToArray();
            }
        }
    }
}
