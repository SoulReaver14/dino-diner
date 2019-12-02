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
        public List<IMenuItem> MenuItems;

        [BindProperty]
        public float? MinPrice { get; set; }

        public void OnGet()
        {
            MenuItems = menu.AvailableMenuItems;
        }

        public void OnPost()
        {
            MenuItems = menu.AvailableMenuItems;

            /*
            if(MinPrice != null)
            {
                MenuItems.Where()
            }
            */
        }
    }
}