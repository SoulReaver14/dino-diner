using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Fryceritops : Side
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
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
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
        /// Override for ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ( size.ToString() + " Fryceritops");
        }
    }
}
