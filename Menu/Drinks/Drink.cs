using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public abstract class Drink : IMenuItem, IOrderItem
    {
        protected List<string> ingredients = new List<string>();


        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; protected set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; protected set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                return new List<string>(ingredients);
            }
        }


        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Private Backing Variable for Ice
        /// </summary>
        public bool Ice = true;

        /// <summary>
        /// Method for holding ice on the order.
        /// </summary>
        public virtual void HoldIce()
        {
            Ice = false;
        }

        /// <summary>
        /// Returns a description for the drinks ToString method
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Abstract method for Special that will be implemented into all the drinks to return a string containing all the special changes
        /// </summary>
        public abstract string[] Special { get; }
    }
}
