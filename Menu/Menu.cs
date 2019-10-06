using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

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
        public List<string> AvailableDrinksList = new List<string>();
        public List<string> AvailableEntreesList = new List<string>();
        public List<string> AvailableSidesList = new List<string>();
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
        /// <summary>
        /// Menu constructor adding all ingredients to 3 lists
        /// </summary>
        public Menu()
        {
            AvailableDrinksList.Add(java.ToString() + "/n" + soda.ToString() + "/n" + tea.ToString() + "/n" + water.ToString());
            AvailableEntreesList.Add(brontowurst.ToString() + "/n" + dinonuggets.ToString() + "/n" + ppbj.ToString() + "/n" + pterodactylwings.ToString() + "/n" + steakburger.ToString() + "/n" + trexburger.ToString() + "/n" + vwrap.ToString());
            AvailableSidesList.Add(fries.ToString() + "/n" + macandcheese.ToString() + "/n" + mezzorellasticks.ToString() + "/n" + tots.ToString());
        }
        /// <summary>
        /// Property that returns a string containing all available menu items
        /// </summary>
        public string AvailableMenuItems
        {
            get
            {
                return (AvailableDrinksList.ToString() + "/n" + AvailableEntreesList.ToString() + "/n" + AvailableSides.ToString());
            }
        }
        /// <summary>
        /// Property that returns a string containing all available entrees
        /// </summary>
        public string AvailableEntrees
        {
            get
            {
                return AvailableEntreesList.ToString();
            }
        }
        /// <summary>
        /// Property that returns a string containing all available drinks
        /// </summary>
        public string AvailableDrinks
        {
            get
            {
                return AvailableDrinksList.ToString();
            }
        }
        /// <summary>
        /// Property that returns a string containing all available sides
        /// </summary>
        public string AvailableSides
        {
            get
            {
                return AvailableSidesList.ToString();
            }
        }
        /// <summary>
        /// Property that returns a string containing all available combos
        /// </summary>
        public string AvailableCombos
        {
            get
            {
                return (brontocombo.ToString() + "/n" + nuggetcombo.ToString() + "/n" + pbjcombo.ToString() + "/n" + wingcombo.ToString() + "/n" + steakburgercombo.ToString() + "/n" + trexburgercombo.ToString() + "/n" + wrapcombo.ToString());
            }
        }

    }
}
