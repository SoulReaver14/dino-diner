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
using System.Collections.ObjectModel;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SelectFlavor.xaml
    /// </summary>
    public partial class SelectFlavor : Page
    {
        private Sodasaurus soda;
        public SelectFlavor(Sodasaurus soda)
        {
            InitializeComponent();
            this.soda = soda;
        }
        private void OnFlavorClick(object sender, RoutedEventArgs args)
        {
            if (sender is Button element)
            {
                soda.Flavor = (DinoDiner.Menu.SodasaurusFlavor)Enum.Parse(typeof(SodasaurusFlavor), element.Tag.ToString());
                NavigationService.GoBack();
            }
        }
    }
}
