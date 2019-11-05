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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        private bool sideconstructor;
        private CretaceousCombo combo;
        private Side side { get; set; }
        /// <summary>
        /// This constructor is used if the page came from mainmenu category
        /// </summary>
        /// <param name="combo"></param>
        public SideSelection(Side side = null)
        {
            sideconstructor = true;
            InitializeComponent();
            this.side = side;
            SmallRadio.IsEnabled = false;
            MediumRadio.IsEnabled = false;
            LargeRadio.IsEnabled = false;
        }

        /// <summary>
        /// This constructor is used if the page came from combo selection
        /// </summary>
        /// <param name="combo"></param>
        public SideSelection(CretaceousCombo combo)
        {
            sideconstructor = false;
            InitializeComponent();
            this.combo = combo;
            SmallRadio.IsEnabled = false;
            MediumRadio.IsEnabled = false;
            LargeRadio.IsEnabled = false;
        }

        /// <summary>
        /// Occurs when fryceritops button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {
            if (sideconstructor == true)
            {
                if (DataContext is Order order)
                {
                    side = new Fryceritops();
                    order.Items.Add(side);
                }
                SmallRadio.IsEnabled = true;
                MediumRadio.IsEnabled = true;
                LargeRadio.IsEnabled = true;
            }
            else
            {
                combo.Side = new Fryceritops();
                NavigationService.GoBack();
            }
        }

        /// <summary>
        /// Occurs when meteor mac and cheese button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            if (sideconstructor == true)
            {
                if (DataContext is Order order)
                {
                    side = new MeteorMacAndCheese();
                    order.Items.Add(side);
                }
                SmallRadio.IsEnabled = true;
                MediumRadio.IsEnabled = true;
                LargeRadio.IsEnabled = true;
            }
            else
            {
                combo.Side = new MeteorMacAndCheese();
                NavigationService.GoBack();
            }
        }

        /// <summary>
        /// Occurs when mezzorella sticks button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            if (sideconstructor == true)
            {
                if (DataContext is Order order)
                {
                    side = new MezzorellaSticks();
                    order.Items.Add(side);
                }
                SmallRadio.IsEnabled = true;
                MediumRadio.IsEnabled = true;
                LargeRadio.IsEnabled = true;
            }
            else
            {
                combo.Side = new MezzorellaSticks();
                NavigationService.GoBack();
            }
        }

        /// <summary>
        /// Occurs when triceritots button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectTriceritots(object sender, RoutedEventArgs args)
        {
            if (sideconstructor == true)
            {
                if (DataContext is Order order)
                {
                    side = new Triceritots();
                    order.Items.Add(side);
                }
                SmallRadio.IsEnabled = true;
                MediumRadio.IsEnabled = true;
                LargeRadio.IsEnabled = true;
            }
            else
            {
                combo.Side = new Triceritots();
                NavigationService.GoBack();
            }
        }

        /// <summary>
        /// Allows the user to determine the size of the side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
                if (sender is FrameworkElement element)
                {
                    side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                    NavigationService.Navigate(new MenuCategorySelection());
                }
        }
    }
}
