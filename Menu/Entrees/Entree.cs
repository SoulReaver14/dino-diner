using System;
using System.Collections.Generic;
using System.Text;
/* Entree.cs
 * Author: Anthony Garvalena
 */

namespace DinoDiner.Menu
{

        public abstract class Entree: IMenuItem, IOrderItem
    {
            protected List<string> ingredients = new List<string>();

            /// <summary>
            /// Gets and sets the price
            /// </summary>
            public double Price { get; set; }

            /// <summary>
            /// Gets and sets the calories
            /// </summary>
            public uint Calories { get; set; }

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
