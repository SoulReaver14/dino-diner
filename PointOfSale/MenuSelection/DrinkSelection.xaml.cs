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
        private bool drinkconstructor = true;
        /// <summary>
        /// Private Cretaceous Combo property
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Private Drink Property
        /// </summary>
        private Drink drink { get; set; }

        /// <summary>
        /// This constructor is used if the page came from mainmenu category
        /// </summary>
        /// <param name="combo"></param>
        public DrinkSelection(Drink drink = null)
        {
            drinkconstructor = true;
            InitializeComponent();
            this.drink = drink;
            SmallRadioButton.IsEnabled = false;
            MediumRadioButton.IsEnabled = false;
            LargeRadioButton.IsEnabled = false;
        }

        /// <summary>
        /// This constructor is used if the page came from combo selection
        /// </summary>
        /// <param name="combo"></param>
        public DrinkSelection(CretaceousCombo combo)
        {
            drinkconstructor = false;
            InitializeComponent();
            this.combo = combo;
            SmallRadioButton.IsEnabled = false;
            MediumRadioButton.IsEnabled = false;
            LargeRadioButton.IsEnabled = false;
        }

        /// <summary>
        /// Occurs when sodasaurus button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnSelectSodasaurus(object sender, RoutedEventArgs args)
        {
            if (drinkconstructor == true)
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
            else
            {
                    Sodasaurus soda = new Sodasaurus();
                    combo.Drink = soda;
                    NavigationService.Navigate(new CustomizeSodasaurus(combo));
            }
        }

        /// <summary>
        /// Occurs when java button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectJava(object sender, RoutedEventArgs args)
        {
            if (drinkconstructor == true)
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
            else
            {
                    JurassicJava java = new JurassicJava();
                    combo.Drink = java;
                    NavigationService.Navigate(new CustomizeJurassicJava(combo));
            }
        }

        /// <summary>
        /// Occurs when tea button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTea(object sender, RoutedEventArgs args)
        {
            if (drinkconstructor == true)
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
            else
            {
                Tyrannotea tea = new Tyrannotea();
                combo.Drink = tea;
                NavigationService.Navigate(new CustomizeTyrannotea(combo));
            }
        }

        /// <summary>
        /// Occurs when water button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectWater(object sender, RoutedEventArgs args)
        {
            if (drinkconstructor == true)
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
            else
            {
                Water water = new Water();
                combo.Drink = water;
                NavigationService.Navigate(new CustomizeWater(combo));
            }
        }

        /// <summary>
        /// Allows the user to choose the size of the drinks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
