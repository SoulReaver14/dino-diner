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
        public void AddingMultipleEntreesShouldHaveCorrectSubtotalCost()
        {
            Order order = new Order();
            PterodactylWings pw = new PterodactylWings();
            Brontowurst bw = new Brontowurst();
            Sodasaurus soda = new Sodasaurus();
            order.Items.Add(pw);
            order.Items.Add(bw);
            order.Items.Add(soda);
            Assert.Equal<double>(14.07, order.SubtotalCost);
        }
        [Fact]

        public void AddingEntreeShouldHaveCorrectSubtotalCost()
        {
            Order order = new Order();
            PterodactylWings pw = new PterodactylWings();
            order.Items.Add(pw); //Having issues
            Assert.Equal<double>(7.21, order.SubtotalCost);
        }

        [Fact]
        public void AddingEntreeShouldHaveCorrectTotalCost()
        {
            Order order = new Order();
            PterodactylWings pw = new PterodactylWings();
            order.Items.Add(pw); //Having issues
            Assert.Equal<double>(8.1473, order.TotalCost);
        }

        [Fact]
        public void SubtotalCostCannotBeNegative()
        {
            Order order = new Order();
            MockPterodactylWings mpw = new MockPterodactylWings();
            order.Items.Add(mpw);
            Assert.Equal<double>(0, order.SubtotalCost);
        }

        [Fact]
        public void SalesTaxShouldBeCorrect()
        {
            Order order = new Order();
            Assert.Equal<double>(.065, order.SalesTaxRate);
        }
    }
}
