using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;


namespace DinoDiner.Menu
{
    public class CretaceousCombo
    {
        /// <summary>
        /// Public Entree Property
        /// </summary>
        public Entree Entree { get; set; }

        /// <summary>
        /// Private Side Field
        /// </summary>
        private Side side;

        /// <summary>
        /// Side method that sets the size
        /// </summary>
        public Side Side {
            get { return side; }
            set
            {
                side = value;
                side.Size = size;
            }
        }

        /// <summary>
        /// Public Drink Property
        /// </summary>
        public Drink Drink { get; set; }


        /// <summary>
        /// Public Price Method that sets the price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - .25;
            }
        }

        /// <summary>
        /// Public Calories Method that sets the calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Private Size field that is initially set to small
        /// </summary>
        private Size size = Size.Small;
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
            }
        }

        /// <summary>
        /// Public ingredients method that adds all the ingredients from the entire combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// Cretaceous Combo Constructor
        /// </summary>
        /// <param name="entree"></param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }

        /// <summary>
        /// Override for ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (Entree.ToString() + " Combo");
        }
    }
}
