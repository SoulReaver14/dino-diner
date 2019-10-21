using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/* DinoNuggets.cs
 * Author: Anthony Garvalena
 */

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree, INotifyPropertyChanged
    {
        private int count = 0;
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
        /// An event handler for PropertyChanged events for Price, Calories, and Specials
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Method to add a Chicken Nugget to the ingredients
        /// </summary>
        public void AddNugget()
        {
            count += 1;
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

        /// <summary>
        /// Returns a string[] that contains strings pertaining to special things to remove or add to the dish.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.Add(count.ToString() + " " + "Extra Nuggets");
                return special.ToArray();
            }
        }

    }
}
