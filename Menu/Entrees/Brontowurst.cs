using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst : Entree
    {

        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;
            ingredients.Add("Brautwurst");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Peppers");
            ingredients.Add("Onion");
        }

        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
        }

        public void HoldPeppers()
        {
            ingredients.Remove("Peppers");
        }

        public void HoldOnion()
        {
            ingredients.Remove("Onion");
        }
    }
}
