using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ : Entree
    {


        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;
            ingredients.Add("Bread");
            ingredients.Add("Peanut Butter");
            ingredients.Add("Jelly");
        }

        public void HoldPeanutButter()
        {
            ingredients.Remove("Peanut Butter");
        }

        public void HoldJelly()
        {
            ingredients.Remove("Jelly");
        }
    }
}
