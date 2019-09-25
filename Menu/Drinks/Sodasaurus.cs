using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus : Drinks
    {
        private SodasaurusFlavor flavor;
        private Size size;
        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }

        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");
        }
        public override Size Size {
            get { return size; }
            set {
                if (value == Size.Small)
                {
                    Price = 1.50;
                    Calories = 112;
                }
                if ( value == Size.Medium )
                {
                    Price = 2.00;
                    Calories = 156;
                }
                if (value == Size.Large)
                {
                    Price = 2.50;
                    Calories = 208;
                }
            }
        }
    }
}
