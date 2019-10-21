using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Water : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Public Boolean Lemon
        /// </summary>
        public bool lemon = false;

        /// <summary>
        /// Private Size backing field
        /// </summary>
        private Size size;

        /// <summary>
        /// Public Water Constructor setting price and calories and ingredients to their defaults
        /// </summary>
        public Water()
        {
            Price = .1;
            Calories = 0;
            ingredients.Add("Water");
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
        /// Public Size Method that sets the price and calories accordingly
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                if (value == Size.Small)
                {
                    Price = .10;
                    Calories = 0;
                }
                if (value == Size.Medium)
                {
                    Price = .10;
                    Calories = 0;
                }
                if (value == Size.Large)
                {
                    Price = .1;
                    Calories = 0;
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
        /// Public Add Lemon method which sets the lemon method to true and adds lemon to ingredients
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
            return (size.ToString() + " Water");
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
