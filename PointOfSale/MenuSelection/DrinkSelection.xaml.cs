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
            SmallRadioButton.IsEnabled = false;
            MediumRadioButton.IsEnabled = false;
            LargeRadioButton.IsEnabled = false;
        }

        private Drink drink { get; set; }

        void OnSelectSodasaurus(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Sodasaurus soda = new Sodasaurus();
                drink = soda;
                order.Items.Add(soda);
                NavigationService.Navigate(new CustomizeSodasaurus(soda));
            }
            SmallRadioButton.IsEnabled = true;
            MediumRadioButton.IsEnabled = true;
            LargeRadioButton.IsEnabled = true;
        }

        private void OnSelectJava(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                JurassicJava java = new JurassicJava();
                drink = java;
                order.Items.Add(java);
                NavigationService.Navigate(new CustomizeJurassicJava(java));
            }
            SmallRadioButton.IsEnabled = true;
            MediumRadioButton.IsEnabled = true;
            LargeRadioButton.IsEnabled = true;
        }

        private void OnSelectTea(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Tyrannotea tea = new Tyrannotea();
                drink = tea;
                order.Items.Add(tea);
                NavigationService.Navigate(new CustomizeTyrannotea(tea));
            }
            SmallRadioButton.IsEnabled = true;
            MediumRadioButton.IsEnabled = true;
            LargeRadioButton.IsEnabled = true;
        }

        private void OnSelectWater(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Water water = new Water();
                drink = water;
                order.Items.Add(water);
                NavigationService.Navigate(new CustomizeWater(water));
            }
            SmallRadioButton.IsEnabled = true;
            MediumRadioButton.IsEnabled = true;
            LargeRadioButton.IsEnabled = true;
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
