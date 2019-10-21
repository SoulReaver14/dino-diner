using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/* Fryceritops.cs
 * Author: Anthony Garvalena
 */

namespace DinoDiner.Menu
{
    public class Fryceritops : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// Private size field
        /// </summary>
        private Size size;

        /// <summary>
        /// Overridden Size method to change price and calories depending on the size
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        NotifyOfPropertyChanged("Description");
                        NotifyOfPropertyChanged("Price");
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        NotifyOfPropertyChanged("Description");
                        NotifyOfPropertyChanged("Price");
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        NotifyOfPropertyChanged("Description");
                        NotifyOfPropertyChanged("Price");
                        break;
                }
            }
            get { return size; }
        }

        /// <summary>
        /// Fryceritops constructor
        /// </summary>
        public Fryceritops()
        {
            Price = .99;
            Calories = 222;
            ingredients.Add("Potato");
            ingredients.Add("Salt");
            ingredients.Add("Vegetable Oil");
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
        /// Override for ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ( size.ToString() + " Fryceritops");
        }

        /// <summary>
        /// Returns a string[] that contains strings pertaining to special things to remove or add to the dish.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }


    }
}
