using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order
    {
        IObservable<IOrderItem> Items { get; set; }


        /// <summary>
        /// Property determining the Subtotal Cost
        /// </summary>
        double SubtotalCost { get; }

        /// <summary>
        /// Property determining the Sales Tax Rate Cost
        /// </summary>
        //double SalesTaxRate { get; protected set; }

        /// <summary>
        /// Property determining the Sales Tax Cost
        /// </summary>
        double SalesTaxCost { get; }

        /// <summary>
        /// Property determining the Total Cost
        /// </summary>
        double TotalCost { get; }
    }
}
