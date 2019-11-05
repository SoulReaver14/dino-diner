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
        private bool drinkconstructor = true;
        private JurassicJava java;

        public CustomizeJurassicJava(JurassicJava java)
        {
            drinkconstructor = true;
            InitializeComponent();
            this.java = java;
        }

        public CustomizeJurassicJava(CretaceousCombo combo)
        {
            drinkconstructor = false;
            InitializeComponent();
            this.java = (JurassicJava)combo.Drink;
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
