using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class VelociWrap : Entree
    {
        //Backing Variables
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

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
        /// An event handler for PropertyChanged events for Price, Calories, and Specials
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Removes dressing from ingredients
        /// </summary>
        public void HoldDressing()
        {
            dressing = false;
            ingredients.Remove("Ceasar Dressing");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes lettuce from ingredients
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
            ingredients.Remove("Romaine Lettuce");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes cheese from ingredients
        /// </summary>
        public void HoldCheese()
        {
            cheese = false;
            ingredients.Remove("Parmesan Cheese");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Override for ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }

        /// <summary>
        /// Returns a string[] that contains strings pertaining to special things to remove or add to the dish.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!dressing) special.Add("Ceasar Dressing");
                if (!lettuce) special.Add("Hold Romaine Lettuce");
                if (!cheese) special.Add("Hold Parmesan Cheese");;
                return special.ToArray();
            }
        }
    }
}
