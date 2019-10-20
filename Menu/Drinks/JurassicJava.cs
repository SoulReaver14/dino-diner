using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    public class JurassicJava : Drink
    {
        /// <summary>
        /// public boolean for leaving room for cream
        /// </summary>
        private bool RoomForCream = false;
        /// <summary>
        /// public boolean for decaf java
        /// </summary>
        private bool decaf = false;
        /// <summary>
        /// Public boolean Sweet with a getter and setter allowing for the boolean of sweet to be retrieved and for sweet to be changed while adding cane sugar if sweet is true
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                decaf = value;
                if (decaf == true)
                NotifyOfPropertyChanged("Description");
            }
        }

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
        /// An event handler for PropertyChanged events for Price, Calories, and Specials
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
            }
        }

        /// <summary>
        /// This allows ice to be added to the drink
        /// </summary>
         public void AddIce()
        {
            this.Ice = true;
            NotifyOfPropertyChanged("Special");
        }
        
        /// <summary>
        /// This allows for room for cream to be added
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Override for ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if(Decaf == false)
            return (size.ToString() + " Jurassic Java");
            else
            return (size.ToString() + " Decaf" + " Jurassic Java");
        }

        /// <summary>
        /// Returns a string[] that contains strings pertaining to special things to remove or add to the dish.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Ice == true) special.Add("Add Ice");
                if (RoomForCream == true) special.Add("Leave Room For Cream");
                return special.ToArray();
            }
        }

    }
}
