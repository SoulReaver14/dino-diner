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

        public Menu menu = new Menu();
        public IEnumerable<IMenuItem> MenuItems;

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public List<string> excludedIngredients { get; set; } = new List<string>();

        [BindProperty]
        public float? minimumPrice { get; set; }

        [BindProperty]
        public float? maximumPrice { get; set; }

        public void OnGet()
        {
            MenuItems = menu.AvailableMenuItems;
        }

        public void OnPost()
        {
            MenuItems = menu.AvailableMenuItems;

            if(search != null)
            {
                MenuItems = MenuItems.Where(menu => menu.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            if(minimumPrice != null)
            {
                MenuItems = MenuItems.Where(menu => menu.Price >= minimumPrice);
            }

            if (maximumPrice != null)
            {
                MenuItems = MenuItems.Where(menu => menu.Price <= maximumPrice);
            }

            if(menuCategory.Count != 0)
            {
                MenuItems = MenuItems.Where(menu => (menu is Entree && menuCategory.Contains("Entree")) || (menu is CretaceousCombo && menuCategory.Contains("Combo")) || (menu is Side && menuCategory.Contains("Side")) || (menu is Drink && menuCategory.Contains("Drink")));
            }

            if(excludedIngredients.Count != 0)
            {
                foreach(string s in excludedIngredients)
                {
                    MenuItems = MenuItems.Where(menu => !menu.Ingredients.Contains(s));
                }
            }


        }
    }
}