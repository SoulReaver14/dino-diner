using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        /// <summary>
        /// Public Boolean Lemon
        /// </summary>
        public bool Lemon = false;

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
            }
        }

        /// <summary>
        /// Public Add Lemon method which sets the lemon method to true and adds lemon to ingredients
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
        }
    }
}
