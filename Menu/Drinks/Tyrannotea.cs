using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
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
            }
        }

        /// <summary>
        /// Public boolean Lemon
        /// </summary>
        public bool Lemon = false;


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
            }
        }

        /// <summary>
        /// Public Add Lemon method which sets the Private Lemon method to true and adding Lemon to the ingredients
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
        }

    }
}
