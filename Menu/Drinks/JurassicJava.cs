using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurassicJava : Drink
    {
        /// <summary>
        /// public boolean for leaving room for cream
        /// </summary>
        public bool RoomForCream = false;
        /// <summary>
        /// public boolean for decaf java
        /// </summary>
        public bool Decaf = false;
        /// <summary>
        /// private size backing field
        /// </summary>
        private Size size;

        /// <summary>
        /// Jurassic Java Constructor
        /// </summary>
        public JurassicJava()
        {
            this.Ice = false;
            Price = .59;
            Calories = 2;
            ingredients.Add("Water");
            ingredients.Add("Natural Coffee");
        }

        /// <summary>
        /// Allows the size to be changed, which then changes the price and calories accordingly
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                if (value == Size.Small)
                {
                    Price = .59;
                    Calories = 2;
                }
                if (value == Size.Medium)
                {
                    Price = .99;
                    Calories = 4;
                }
                if (value == Size.Large)
                {
                    Price = 1.49;
                    Calories = 8;
                }
            }
        }

        /// <summary>
        /// This allows ice to be added to the drink
        /// </summary>
         public void AddIce()
        {
            this.Ice = true;
        }
        
        /// <summary>
        /// This allows for room for cream to be added
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

    }
}
