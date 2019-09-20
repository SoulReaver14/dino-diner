using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger : Entree
    {


        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Lettuce");
            ingredients.Add("Onion");
            ingredients.Add("Tomato");
            ingredients.Add("Pickle");
            ingredients.Add("Ketchup");
            ingredients.Add("Mustard");
            ingredients.Add("Mayo");
        }

        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
        }
        public void HoldLettuce()
        {
            ingredients.Remove("Lettuce");
        }
        public void HoldTomato()
        {
            ingredients.Remove("Tomato");
        }

        public void HoldPickle()
        {
            ingredients.Remove("Pickle");
        }

        public void HoldOnion()
        {
            ingredients.Remove("Onion");
        }

        public void HoldKetchup()
        {
            ingredients.Remove("Ketchup");
        }

        public void HoldMustard()
        {
            ingredients.Remove("Mustard");
        }
        public void HoldMayo()
        {
            ingredients.Remove("Mayo");
        }
    }
}
