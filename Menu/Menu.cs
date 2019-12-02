using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
/* Menu.cs
 * Author: Anthony Garvalena
 */

namespace DinoDiner.Menu
{
    public class Menu
    {
        /// <summary>
        /// All Available Drink fields created
        /// </summary>
        private JurassicJava java = new JurassicJava();
        private Sodasaurus soda = new Sodasaurus();
        private Tyrannotea tea = new Tyrannotea();
        private Water water = new Water();
        /// <summary>
        /// All Available Entree fields created
        /// </summary>
        private Brontowurst brontowurst = new Brontowurst();
        private DinoNuggets dinonuggets = new DinoNuggets();
        private PrehistoricPBJ ppbj = new PrehistoricPBJ();
        private PterodactylWings pterodactylwings = new PterodactylWings();
        private SteakosaurusBurger steakburger = new SteakosaurusBurger();
        private TRexKingBurger trexburger = new TRexKingBurger();
        private VelociWrap vwrap = new VelociWrap();
        /// <summary>
        /// All Available Side fields created
        /// </summary>
        private Fryceritops fries = new Fryceritops();
        private MeteorMacAndCheese macandcheese = new MeteorMacAndCheese();
        private MezzorellaSticks mezzorellasticks = new MezzorellaSticks();
        private Triceritots tots = new Triceritots();
        //public List<string> AvailableDrinksList = new List<string>(); NOT USING ANYMORE
        //public List<string> AvailableEntreesList = new List<string>();
        //public List<string> AvailableSidesList = new List<string>();
        /// <summary>
        /// All Available Combo fields created
        /// </summary>
        private CretaceousCombo brontocombo = new CretaceousCombo(new Brontowurst());
        private CretaceousCombo nuggetcombo = new CretaceousCombo(new DinoNuggets());
        private CretaceousCombo pbjcombo = new CretaceousCombo(new PrehistoricPBJ());
        private CretaceousCombo wingcombo = new CretaceousCombo(new PterodactylWings());
        private CretaceousCombo steakburgercombo = new CretaceousCombo(new SteakosaurusBurger());
        private CretaceousCombo trexburgercombo = new CretaceousCombo(new TRexKingBurger());
        private CretaceousCombo wrapcombo = new CretaceousCombo(new VelociWrap());

        private List<IMenuItem> availablemenuitems = new List<IMenuItem>()
        {
            new CretaceousCombo(new Brontowurst()),
            new CretaceousCombo(new DinoNuggets()),
            new CretaceousCombo(new PrehistoricPBJ()),
            new CretaceousCombo(new PterodactylWings()),
            new CretaceousCombo(new SteakosaurusBurger()),
            new CretaceousCombo(new TRexKingBurger()),
            new CretaceousCombo(new VelociWrap()),
            new Brontowurst(),
            new DinoNuggets(),
            new PrehistoricPBJ(),
            new PterodactylWings(),
            new SteakosaurusBurger(),
            new TRexKingBurger(),
            new VelociWrap(),
            new Fryceritops(),
            new MeteorMacAndCheese(),
            new MezzorellaSticks(),
            new Triceritots(),
            new JurassicJava(),
            new Sodasaurus(),
            new Tyrannotea(),
            new Water()

        };

        private List<IMenuItem> combos = new List<IMenuItem>()
        {
            new CretaceousCombo(new Brontowurst()),
            new CretaceousCombo(new DinoNuggets()),
            new CretaceousCombo(new PrehistoricPBJ()),
            new CretaceousCombo(new PterodactylWings()),
            new CretaceousCombo(new SteakosaurusBurger()),
            new CretaceousCombo(new TRexKingBurger()),
            new CretaceousCombo(new VelociWrap())
        };

        private List<IMenuItem> entrees = new List<IMenuItem>()
        {
            new Brontowurst(),
            new DinoNuggets(),
            new PrehistoricPBJ(),
            new PterodactylWings(),
            new SteakosaurusBurger(),
            new TRexKingBurger(),
            new VelociWrap()
        };

        private List<IMenuItem> sides = new List<IMenuItem>()
        {
            new Fryceritops(),
            new MeteorMacAndCheese(),
            new MezzorellaSticks(),
            new Triceritots(),
        };

        private List<IMenuItem> drinks = new List<IMenuItem>() {
            new JurassicJava(),
            new Sodasaurus(),
            new Tyrannotea(),
            new Water()
        };

        /// <summary>
        /// Menu constructor adding all ingredients to 3 lists
        /// </summary>
        public Menu()
        {
        }
        /// <summary>
        /// Property that returns a string containing all available menu items
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                return availablemenuitems;
            }
        }
        /// <summary>
        /// Property that returns a string containing all available entrees
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                return entrees;
            }
        }
        /// <summary>
        /// Property that returns a string containing all available drinks
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                return drinks;
            }
        }
        /// <summary>
        /// Property that returns a string containing all available sides
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                return sides;
            }
        }
        /// <summary>
        /// Property that returns a string containing all available combos
        /// </summary>
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                return combos;
            }
        }

        private List<string> possibleIngredients = new List<string>();
        public List<string> PossibleIngredients
        {
            get
            {
                //Entree Ingredients
                foreach(string s in brontowurst.Ingredients)
                {
                    if (!possibleIngredients.Contains(s))
                    {
                        possibleIngredients.Add(s);
                    }
                }
                foreach (string s in dinonuggets.Ingredients)
                {
                    if (!possibleIngredients.Contains(s))
                    {
                        possibleIngredients.Add(s);
                    }
                }
                foreach (string s in ppbj.Ingredients)
                {
                    if (!possibleIngredients.Contains(s))
                    {
                        possibleIngredients.Add(s);
                    }
                }
                foreach (string s in pterodactylwings.Ingredients)
                {
                    if (!possibleIngredients.Contains(s))
                    {
                        possibleIngredients.Add(s);
                    }
                }
                foreach (string s in steakburger.Ingredients)
                {
                    if (!possibleIngredients.Contains(s))
                    {
                        possibleIngredients.Add(s);
                    }
                }
                foreach (string s in trexburger.Ingredients)
                {
                    if (!possibleIngredients.Contains(s))
                    {
                        possibleIngredients.Add(s);
                    }
                }
                foreach (string s in vwrap.Ingredients)
                {
                    if (!possibleIngredients.Contains(s))
                    {
                        possibleIngredients.Add(s);
                    }
                }
                foreach (string s in brontowurst.Ingredients)
                {
                    if (!possibleIngredients.Contains(s))
                    {
                        possibleIngredients.Add(s);
                    }
                }
                //Drink Ingredients
                foreach (string s in java.Ingredients)
                {
                    if (!possibleIngredients.Contains(s))
                    {
                        possibleIngredients.Add(s);
                    }
                }
                foreach (string s in soda.Ingredients)
                {
                    if (!possibleIngredients.Contains(s))
                    {
                        possibleIngredients.Add(s);
                    }
                }
                foreach (string s in tea.Ingredients)
                {
                    if (!possibleIngredients.Contains(s))
                    {
                        possibleIngredients.Add(s);
                    }
                }
                foreach (string s in water.Ingredients)
                {
                    if (!possibleIngredients.Contains(s))
                    {
                        possibleIngredients.Add(s);
                    }
                }
                //Side Ingredients
                foreach (string s in fries.Ingredients)
                {
                    if (!possibleIngredients.Contains(s))
                    {
                        possibleIngredients.Add(s);
                    }
                }
                foreach (string s in macandcheese.Ingredients)
                {
                    if (!possibleIngredients.Contains(s))
                    {
                        possibleIngredients.Add(s);
                    }
                }
                foreach (string s in mezzorellasticks.Ingredients)
                {
                    if (!possibleIngredients.Contains(s))
                    {
                        possibleIngredients.Add(s);
                    }
                }
                foreach (string s in tots.Ingredients)
                {
                    if (!possibleIngredients.Contains(s))
                    {
                        possibleIngredients.Add(s);
                    }
                }
                //Return Line
                return possibleIngredients;
            }
        }

    }
}
