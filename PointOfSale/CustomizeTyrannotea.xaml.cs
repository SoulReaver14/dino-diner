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
    /// Interaction logic for CustomizeTyrannotea.xaml
    /// </summary>
    public partial class CustomizeTyrannotea : Page
    {
        private Tyrannotea tea;
        public CustomizeTyrannotea(Tyrannotea tea)
        {
            InitializeComponent();
            this.tea = tea;
        }
        private void OnHoldIce(object sender, RoutedEventArgs args)
        {
            tea.HoldIce();
        }

        private void OnAddLemon(object sender, RoutedEventArgs args)
        {
            tea.AddLemon();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
