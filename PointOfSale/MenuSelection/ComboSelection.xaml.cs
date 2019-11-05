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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }
        void CustomizeCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (sender is Button element)
                {
                    if ((string)element.Tag == "Brontowurst")
                    {
                        Brontowurst brontowurst = new Brontowurst();
                        CretaceousCombo combo = new CretaceousCombo(brontowurst);
                        order.Items.Add(combo);
                        NavigationService.Navigate(new CustomizeComboSelection(combo));
                    }
                    else if ((string)element.Tag == "DinoNuggets")
                    {
                        DinoNuggets dn = new DinoNuggets();
                        CretaceousCombo combo = new CretaceousCombo(dn);
                        order.Items.Add(combo);
                        NavigationService.Navigate(new CustomizeComboSelection(combo));
                    }
                    else if ((string)element.Tag == "PrehistoricPBJ")
                    {
                        PrehistoricPBJ pbj = new PrehistoricPBJ();
                        CretaceousCombo combo = new CretaceousCombo(pbj);
                        order.Items.Add(combo);
                        NavigationService.Navigate(new CustomizeComboSelection(combo));
                    }
                    else if ((string)element.Tag == "PterodactylWings")
                    {
                        PterodactylWings pw = new PterodactylWings();
                        CretaceousCombo combo = new CretaceousCombo(pw);
                        order.Items.Add(combo);
                        NavigationService.Navigate(new CustomizeComboSelection(combo));
                    }
                    else if ((string)element.Tag == "SteakosaurusBurger")
                    {
                        SteakosaurusBurger burger = new SteakosaurusBurger();
                        CretaceousCombo combo = new CretaceousCombo(burger);
                        order.Items.Add(combo);
                        NavigationService.Navigate(new CustomizeComboSelection(combo));
                    }
                    else if ((string)element.Tag == "TRexKingBurger")
                    {
                        TRexKingBurger trex = new TRexKingBurger();
                        CretaceousCombo combo = new CretaceousCombo(trex);
                        order.Items.Add(combo);
                        NavigationService.Navigate(new CustomizeComboSelection(combo));
                    }
                    else if ((string)element.Tag == "VelociWrap")
                    {
                        VelociWrap vw = new VelociWrap();
                        CretaceousCombo combo = new CretaceousCombo(vw);
                        order.Items.Add(combo);
                        NavigationService.Navigate(new CustomizeComboSelection(combo));
                    }
                }
            }
        }
    }
}
