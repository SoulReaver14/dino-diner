using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;
using System.Collections.ObjectModel;

namespace Website.Pages
{
    public class MenuPageModel : PageModel
    {
        /// <summary>
        /// All Available Drink fields created
        /// </summary>
        public JurassicJava java = new JurassicJava();
        public Sodasaurus soda = new Sodasaurus();
        public Tyrannotea tea = new Tyrannotea();
        public Water water = new Water();
        /// <summary>
        /// All Available Entree fields created
        /// </summary>
        public Brontowurst brontowurst = new Brontowurst();
        public DinoNuggets dinonuggets = new DinoNuggets();
        public PrehistoricPBJ ppbj = new PrehistoricPBJ();
        public PterodactylWings pterodactylwings = new PterodactylWings();
        public SteakosaurusBurger steakburger = new SteakosaurusBurger();
        public TRexKingBurger trexburger = new TRexKingBurger();
        public VelociWrap vwrap = new VelociWrap();
        /// <summary>
        /// All Available Side fields created
        /// </summary>
        public Fryceritops fries = new Fryceritops();
        public MeteorMacAndCheese macandcheese = new MeteorMacAndCheese();
        public MezzorellaSticks mezzorellasticks = new MezzorellaSticks();
        public Triceritots tots = new Triceritots();
        /// <summary>
        /// All Available Combo fields created
        /// </summary>
        public CretaceousCombo brontocombo = new CretaceousCombo(new Brontowurst());
        public CretaceousCombo nuggetcombo = new CretaceousCombo(new DinoNuggets());
        public CretaceousCombo pbjcombo = new CretaceousCombo(new PrehistoricPBJ());
        public CretaceousCombo wingcombo = new CretaceousCombo(new PterodactylWings());
        public CretaceousCombo steakburgercombo = new CretaceousCombo(new SteakosaurusBurger());
        public CretaceousCombo trexburgercombo = new CretaceousCombo(new TRexKingBurger());
        public CretaceousCombo wrapcombo = new CretaceousCombo(new VelociWrap());

        public Menu menu = new Menu();

        public void OnGet()
        {
        }
    }
}