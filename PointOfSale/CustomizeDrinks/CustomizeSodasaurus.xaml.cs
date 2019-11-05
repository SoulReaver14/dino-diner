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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeSodasaurus.xaml
    /// </summary>
    public partial class CustomizeSodasaurus : Page
    {
        private bool drinkconstructor = true;
        private Sodasaurus soda;
        public CustomizeSodasaurus(Sodasaurus soda)
        {
            drinkconstructor = true;
            InitializeComponent();
            this.soda = soda;
        }

        public CustomizeSodasaurus(CretaceousCombo combo)
        {
            drinkconstructor = false;
            InitializeComponent();
            this.soda = (Sodasaurus)combo.Drink;
        }

        private void OnFlavorClick(object sender, RoutedEventArgs args)
        {
            if (sender is Button element)
            {
                soda.Flavor = (SodasaurusFlavor)Enum.Parse(typeof(SodasaurusFlavor), element.Tag.ToString());
            }
        }
        private void OnHoldIce(object sender, RoutedEventArgs args)
        {
            soda.HoldIce();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (drinkconstructor == true)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.GoBack();
                NavigationService.GoBack();
            }
        }
    }
}
