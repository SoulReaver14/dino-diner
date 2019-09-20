using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap : Entree
    {

        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
            ingredients.Add("Flour Tortilla");
            ingredients.Add("Chicken Breast");
            ingredients.Add("Ceasar Dressing");
            ingredients.Add("Romaine Lettuce");
            ingredients.Add("Parmesan Cheese");
        }

        public void HoldDressing()
        {
            ingredients.Remove("Ceasar Dressing");
        }

        public void HoldLettuce()
        {
            ingredients.Remove("Romaine Lettuce");
        }

        public void HoldCheese()
        {
            ingredients.Remove("Parmesan Cheese");
        }
    }
}
