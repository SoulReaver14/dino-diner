using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Linq;
/* Order.cs
 * Author: Anthony Garvalena
 */

namespace DinoDiner.Menu
{
    public class Order: INotifyPropertyChanged
    {
        public Order()
        {
            Items.CollectionChanged += CollectionChanged;
            salestaxrate = .065;
        }

        /// <summary>
        /// An event handler for PropertyChanged events for Price, Calories, and Specials
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        void CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
        {
            if(args.Action == NotifyCollectionChangedAction.Add)
            {
                if(args.NewItems[0] is Entree entree)
                {
                    entree.PropertyChanged += ListItemChanged; 
                }
                else if (args.NewItems[0] is Side side)
                {
                    side.PropertyChanged += ListItemChanged;
                }
                else if (args.NewItems[0] is Drink drink)
                {
                    drink.PropertyChanged += ListItemChanged;
                }
                else if (args.NewItems[0] is CretaceousCombo ccombo)
                {
                    ccombo.PropertyChanged += ListItemChanged;
                }
            }
            NotifyOfPropertyChanged("SubtotalCost");
        }

        void ListItemChanged(object sender, PropertyChangedEventArgs args)
        {
            if(args.PropertyName == "Price")
            {
                NotifyOfPropertyChanged("SubtotalCost");
            }
        }

        /// <summary>
        /// Collection of Order items to then show up on the OrderList.Xaml
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// private Backing Variable
        /// </summary>
        private double subtotalcost = 0;

        /// <summary>
        /// Property determining the Subtotal Cost
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                return Items.Sum(item => item.Price) > 0 ? Items.Sum(item => item.Price) : 0;
            }
        }

        /// <summary>
        /// private Backing Variable
        /// </summary>
        private double salestaxrate;

        /// <summary>
        /// Property determining the Sales Tax Rate Cost
        /// </summary>
        public double SalesTaxRate { get { return salestaxrate; } protected set { salestaxrate = .065; } }

        /// <summary>
        /// Property determining the Sales Tax Cost
        /// </summary>
        public double SalesTaxCost { 
            get 
            {
                return (SalesTaxRate * SubtotalCost); 
            } 
        }

        /// <summary>
        /// Property determining the Total Cost
        /// </summary>
        public double TotalCost { 
            get 
            {
                return (SubtotalCost + SalesTaxCost); 
            } 
        }
    }
}
