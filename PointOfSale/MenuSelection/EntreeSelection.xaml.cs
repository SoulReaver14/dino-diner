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
        private Entree entree { get; set; }
        public EntreeSelection(Entree entree = null)
        {
            InitializeComponent();
            this.entree = entree;
        }

        private void OnSelectBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst brontowurst = new Brontowurst();
                entree = brontowurst;
                order.Items.Add(brontowurst);
                NavigationService.Navigate(new CustomizeBrontowurst(brontowurst));
            }
        }

        private void OnSelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets dn = new DinoNuggets();
                entree = dn;
                order.Items.Add(dn);
                NavigationService.Navigate(new CustomizeDinoNuggets(dn));
            }
        }

        private void OnSelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger burger = new SteakosaurusBurger();
                entree = burger;
                order.Items.Add(burger);
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(burger));
            }
        }

        private void OnSelectTrexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger trex = new TRexKingBurger();
                entree = trex;
                order.Items.Add(trex);
                NavigationService.Navigate(new CustomizeTRexKingBurger(trex));
            }
        }

        /// <summary>
        /// Working on Select Prehistoric PBJ w/ Bean
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                entree = pbj;
                order.Items.Add(pbj);
                NavigationService.Navigate(new CustomisePrehistoricPBJ(pbj));
            }
        }

        private void OnSelectPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                order.Items.Add(entree);
            }
        }

        private void OnSelectVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                VelociWrap wrap = new VelociWrap();
                entree = wrap;
                order.Items.Add(wrap);
                NavigationService.Navigate(new CustomizeVelociWrap(wrap));
            }
        }
    }
}
