using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/* Entree.cs
 * Author: Anthony Garvalena
 */

namespace DinoDiner.Menu
{

        public abstract class Entree: IMenuItem, IOrderItem, INotifyPropertyChanged
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
        /// An event handler for PropertyChanged events for Price, Calories, and Specials
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Abstract method for Special that will be implemented into all the entrees to return a string containing all the special changes
        /// </summary>
        public abstract string[] Special { get; }

            /// <summary>
            /// Returns a description for the entrees ToString method
            /// </summary>
            public string Description
            {
                get { return this.ToString(); }
            }



        }
}
