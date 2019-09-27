using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        public bool Lemon = false;

        private SodasaurusFlavor flavor;
        private Size size;

        public Water()
        {
            Price = 1.50;
            Calories = 112;
            ingredients.Add("Water");
        }

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

        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
        }
    }
}
