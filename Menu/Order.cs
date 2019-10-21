using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
/* Order.cs
 * Author: Anthony Garvalena
 */

namespace DinoDiner.Menu
{
    public class Order
    {
        public Order()
        {
            salestaxrate = .065;
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
               foreach(IOrderItem item in Items)
                {
                    subtotalcost += item.Price;
                }
                if (subtotalcost < 0)
                {
                    return 0.0;
                }
                else
                    return subtotalcost;
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
