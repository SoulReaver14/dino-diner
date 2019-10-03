using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree
    {

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
        /// Removes peanut butter from ingredients
        /// </summary>
        public void HoldPeanutButter()
        {
            ingredients.Remove("Peanut Butter");
        }

        /// <summary>
        /// Removes jelly from ingredients
        /// </summary>
        public void HoldJelly()
        {
            ingredients.Remove("Jelly");
        }

        /// <summary>
        /// Override for ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
