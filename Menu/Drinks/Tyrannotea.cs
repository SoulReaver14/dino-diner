using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/* Tyrannotea.cs
 * Author: Anthony Garvalena
 */

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Private size backing field
        /// </summary>
        private Size size;

        /// <summary>
        /// Private boolean sweet
        /// </summary>
        private bool sweet;

        /// <summary>
        /// Public boolean Lemon
        /// </summary>
        public bool lemon = false;

        /// <summary>
        /// Public boolean Sweet with a getter and setter allowing for the boolean of sweet to be retrieved and for sweet to be changed while adding cane sugar if sweet is true
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set
            {
                sweet = value;
                if(sweet == true)
                ingredients.Add("Cane Sugar");
                Size = Size;
                NotifyOfPropertyChanged("Description");
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
        /// Tyrannotea constructor setting price, calories, and ingredients to their defaults.
        /// </summary>
        public Tyrannotea()
        {
            Price = .99;
            Calories = 8;
            ingredients.Add("Water");
            ingredients.Add("Tea");
        }

        /// <summary>
        /// Size method that lets size to be changed, changing price and changing calories depending on if the tea is sweetened.
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                if (value == Size.Small)
                {
                    Price = .99;
                    if(Sweet == true)
                    {
                        Calories = 16;
                    }
                    else
                    {
                        Calories = 8;
                    }
                }
                if (value == Size.Medium)
                {
                    Price = 1.49;
                    if(Sweet == true)
                    {
                        Calories = 32;
                    }
                    else
                    {
                        Calories = 16;
                    }
                }
                if (value == Size.Large)
                {
                    Price = 1.99;
                    if(Sweet == true)
                    {
                        Calories = 64;
                    }
                    else
                    {
                        Calories = 32;
                    }
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
        /// Public Add Lemon method which sets the Private Lemon method to true and adding Lemon to the ingredients
        /// </summary>
        public void AddLemon()
        {
            lemon = true;
            ingredients.Add("Lemon");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Override for ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if(sweet == false)
            return (size.ToString() + " Tyrannotea");
            else
            return (size.ToString() + " Sweet" + " Tyrannotea");
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
                if (lemon == true) special.Add("Add Lemon");
                return special.ToArray();
            }
        }

    }
}
