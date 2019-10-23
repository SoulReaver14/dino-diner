using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/* Sodasaurus.cs
 * Author: Anthony Garvalena
 */

namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Private Enum for all the flavors of soda
        /// </summary>
        private SodasaurusFlavor flavor;
        /// <summary>
        /// Private size backing field
        /// </summary>
        private Size size;

        /// <summary>
        /// SodasaurusFlavor Getter and Setter to allow the flavor to be changed
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }

        /// <summary>
        /// Sodasaurus contructor setting price, calories as well as ingredients
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");

        }

        /// <summary>
        /// Size method which allows size to change, which then changes price and calories accordingly
        /// </summary>
        public override Size Size {
            get { return size; }
            set {
                size = value;
                if (value == Size.Small)
                {
                    Price = 1.50;
                    Calories = 112;
                }
                if (value == Size.Medium )
                {
                    Price = 2.00;
                    Calories = 156;
                }
                if (value == Size.Large)
                {
                    Price = 2.50;
                    Calories = 208;
                }
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
            }
        }

        /// <summary>
        /// Method for holding ice on the order.
        /// </summary>
        public override void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Override for ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (size.ToString() + " " + Flavor.ToString() +  " Sodasaurus");
        }

        /// <summary>
        /// Returns a string[] that contains strings pertaining to special things to remove or add to the dish.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }
    }
}
