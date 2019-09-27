using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        private Size size;
        private bool sweet;
        public bool Sweet
        {
            get { return sweet; }
            set
            {
                sweet = value;
                ingredients.Add("Cane Sugar");
                Size = Size;
            }
        }
        public bool Lemon = false;

        public Tyrannotea()
        {
            Price = .99;
            Calories = 8;
            ingredients.Add("Water");
            ingredients.Add("Tea");
        }
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
                    Calories = 16;
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
            }
        }

        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
        }

    }
}
