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
    /// Interaction logic for CustomizeJurassicJava.xaml
    /// </summary>
    public partial class CustomizeJurassicJava : Page
    {
        private JurassicJava java;
        public CustomizeJurassicJava(JurassicJava java)
        {
            InitializeComponent();
            this.java = java;
        }

        private void OnAddIce(object sender, RoutedEventArgs args)
        {
            java.AddIce();
        }

        private void OnDecaf(object sender, RoutedEventArgs args)
        {
            java.Decaf = true;
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
