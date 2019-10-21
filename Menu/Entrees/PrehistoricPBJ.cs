using System.Collections.Generic;
using System.ComponentModel;
/* PrehistoricPBJ.cs
 * Author: Anthony Garvalena
 */

namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree , INotifyPropertyChanged
    {
        //Backing Variables
        private bool peanutButter = true;
        private bool jelly = true;
        /// <summary>
        /// Constructor for Prehistoric PB&J
        /// </summary>
        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;
            ingredients.Add("Bread");
            ingredients.Add("Peanut Butter");
            ingredients.Add("Jelly");
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
        /// Removes peanut butter from ingredients
        /// </summary>
        public void HoldPeanutButter()
        {
            peanutButter = false;
            ingredients.Remove("Peanut Butter");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes jelly from ingredients
        /// </summary>
        public void HoldJelly()
        {
            jelly = false;
            ingredients.Remove("Jelly");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Override for ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }

        /// <summary>
        /// Returns a string[] that contains strings pertaining to special things to remove or add to the dish.
        /// </summary>
        public override string[] Special  //NOTE IMPLEMENT THIS FOR ALL THE ENTREE SIDE AND DRINK
        {
            get
            {
                List<string> special = new List<string>();
                if (!peanutButter) special.Add("Hold Peanut Butter");
                if (!jelly) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }
    }
}
