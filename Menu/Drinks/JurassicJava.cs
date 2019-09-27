using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurassicJava : Drink
    {
        public bool RoomForCream = false;
        public bool Decaf = false;
        private Size size;

        public JurassicJava()
        {
            this.Ice = false;
            Price = .59;
            Calories = 2;
            ingredients.Add("Water");
            ingredients.Add("Natural Coffee");
        }
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
         public void AddIce()
        {
            this.Ice = true;
        }
        
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

    }
}
