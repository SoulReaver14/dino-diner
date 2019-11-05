using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;
using DDSize = DinoDiner.Menu.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeComboSelection.xaml
    /// </summary>
    public partial class CustomizeComboSelection : Page
    {
        private CretaceousCombo combo;
        public CustomizeComboSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            if (combo.Entree.ToString() == "PterodactylWings")
            {
                EntreeButton.IsEnabled = false;
            }
        }

        void EntreeSelect(object sender, RoutedEventArgs args)
        {
            if(combo.Entree.ToString() == "Brontowurst")
            {
                NavigationService.Navigate( new CustomizeBrontowurst((Brontowurst)combo.Entree));
            }
            else if(combo.Entree.ToString() == "Dino-Nuggets")
            {
                NavigationService.Navigate(new CustomizeDinoNuggets((DinoNuggets)combo.Entree));
            }
            else if (combo.Entree.ToString() == "Prehistoric PB&J")
            {
                NavigationService.Navigate(new CustomisePrehistoricPBJ((PrehistoricPBJ)combo.Entree));
            }
            else if (combo.Entree.ToString() == "Steakosaurus Burger")
            {
                NavigationService.Navigate(new CustomizeSteakosaurusBurger((SteakosaurusBurger)combo.Entree));
            }
            else if (combo.Entree.ToString() == "T-Rex King Burger")
            {
                NavigationService.Navigate(new CustomizeTRexKingBurger((TRexKingBurger)combo.Entree));
            }
            else if (combo.Entree.ToString() == "Veloci-Wrap")
            {
                NavigationService.Navigate(new CustomizeVelociWrap((VelociWrap)combo.Entree));
            }
        }

        void DrinkSelect(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(combo));
        }

        void SideSelect(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(combo));
        }

        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is RadioButton element)
            {
                combo.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
