using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class OrderTests
    {
        [Fact]

        public void AddingEntreeShouldHaveCorrectPrice()
        {
            Order order = new Order();
            PterodactylWings pw = new PterodactylWings();
            order.Items.Add(pw); //Having issues
            Assert.Equal<double>(7.21, order.SubtotalCost);
        }
    }
}
