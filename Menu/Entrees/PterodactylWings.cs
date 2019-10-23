using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
/* PterodactylWings.cs
 * Author: Anthony Garvalena
 */

namespace DinoDiner.Menu
{
    public class PterodactylWings : Entree, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Pterodactyl Wings Constructor
        /// </summary>
        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
            ingredients.Add("Chicken");
            ingredients.Add("Wing Sauce");
        }

        /// <summary>
        /// Override for ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }

        /// <summary>
        /// Returns a string[] that contains strings pertaining to special things to remove or add to the dish.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }
    }
}
