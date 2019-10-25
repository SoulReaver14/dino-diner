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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        public EntreeSelection(Entree entree = null)
        {
            InitializeComponent();
            this.entree = entree;
        }

        private Entree entree { get; set; }

        private void OnSelectBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new Brontowurst();
                order.Items.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        private void OnSelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new DinoNuggets();
                order.Items.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        private void OnSelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new SteakosaurusBurger();
                order.Items.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        private void OnSelectTrexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new TRexKingBurger();
                order.Items.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        private void OnSelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PrehistoricPBJ();
                order.Items.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        private void OnSelectPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                order.Items.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        private void OnSelectVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new VelociWrap();
                order.Items.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
