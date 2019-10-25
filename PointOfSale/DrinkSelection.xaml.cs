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
using System.Collections.ObjectModel;
using DDSize = DinoDiner.Menu.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection(Drink drink = null)
        {
            InitializeComponent();
            this.drink = drink;
            flavor.IsEnabled = false;
            addlemon.IsEnabled = false;
            holdice.IsEnabled = false;
            SmallRadioButton.IsEnabled = false;
            MediumRadioButton.IsEnabled = false;
            LargeRadioButton.IsEnabled = false;
        }

        private Drink drink { get; set; }

        void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SelectFlavor());
        }

        private void OnSelectJava(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                order.Items.Add(drink);
            }
            SmallRadioButton.IsEnabled = true;
            MediumRadioButton.IsEnabled = true;
            LargeRadioButton.IsEnabled = true;
            addlemon.Content = "Decaf";
            addlemon.IsEnabled = true;
            holdice.Content = "Add Ice";
            holdice.IsEnabled = true;
        }

        private void OnSelectTea(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                order.Items.Add(drink);
            }
            SmallRadioButton.IsEnabled = true;
            MediumRadioButton.IsEnabled = true;
            LargeRadioButton.IsEnabled = true;
            addlemon.Content = "Add Lemon";
            addlemon.IsEnabled = true;
            holdice.Content = "Hold Ice";
            holdice.IsEnabled = true;
        }

        private void OnSelectWater(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Water();
                order.Items.Add(drink);
            }
            SmallRadioButton.IsEnabled = true;
            MediumRadioButton.IsEnabled = true;
            LargeRadioButton.IsEnabled = true;
            addlemon.Content = "Add Lemon";
            addlemon.IsEnabled = true;
            holdice.Content = "Hold Ice";
            holdice.IsEnabled = true;
        }

        // COMPLETE THIS
        private void OnSelectLemon(object sender, RoutedEventArgs args)
        {
            if(sender is FrameworkElement element)
            {
                if((string)addlemon.Content == "Decaf")
                {
                    
                }
                else if ((string)addlemon.Content == "Add Lemon")
                {

                }
            }
        }

        // COMPLETE THIS
        private void OnSelectHoldIce(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                if ((string)addlemon.Content == "Add Ice")
                {

                }
                else if ((string)addlemon.Content == "Hold Ice")
                {

                }
            }
        }

        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is RadioButton element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Content.ToString());
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
