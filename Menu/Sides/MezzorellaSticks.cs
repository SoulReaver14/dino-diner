using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// Private Size Field
        /// </summary>
        private Size size;

        /// <summary>
        /// Overridden Size Method that changes the price and calories depending on the size
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
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                }
            }
            get { return size; }
        }

        /// <summary>
        /// Mezzorella Sticks Constructor
        /// </summary>
        public MezzorellaSticks()
        {
            Price = .99;
            Calories = 540;
            ingredients.Add("Cheese Product");
            ingredients.Add("Breading");
            ingredients.Add("Vegetable Oil");
        }

        /// <summary>
        /// Override for ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (size.ToString() + " Mezzorella Sticks");
        }
    }
}
