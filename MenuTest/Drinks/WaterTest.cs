using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        //1. The correct default price, calories, ice, size, and lemon properties.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal<double>(.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }

        [Fact]

        public void ShouldHaveDefaultSize()
        {
            Water water = new Water();
            Assert.Equal<Size>(Size.Small, water.Size);
        }

        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Water water = new Water();
            Assert.False(water.lemon);
        }

        //2. The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<double>(.10, water.Price);

        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<uint>(0, water.Calories);
        }

        //3. That invoking HoldIce() results in the Ice property being false
       [Fact]
        public void ShouldHoldIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }
        //4. That invoking AddLemon() sets results in the Lemon property being true.
        [Fact]
        public void ShouldAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.lemon);
        }

        //Beginning of Notification Tests

        [Fact]
        public void DescriptionShouldBeCorrectForSizeSmall()
        {
            Water water = new Water();
            water.Size = Size.Small;
            Assert.Equal("Small Water", water.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal("Medium Water", water.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal("Large Water", water.Description);
        }

        [Fact]
        public void SpecialShouldbeEmptyByDefault()
        {
            Water water = new Water();
            Assert.Empty(water.Special);
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeSmall()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Description", () =>
            {
                water.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeMedium()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Description", () =>
            {
                water.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeLarge()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Description", () =>
            {
                water.Size = Size.Large;
            });
        }

        [Fact]
        public void HoldIceShouldAddToSpecial()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.Collection<string>(water.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }

        [Fact]
        public void AddLemonShouldAddToSpecial()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Collection<string>(water.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }

        [Fact]
        public void HoldIceShouldNotifySpecialChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Special", () =>
            {
                water.HoldIce();
            });
        }

        [Fact]
        public void AddLemonShouldNotifySpecialChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Special", () =>
            {
                water.AddLemon();
            });
        }
    }
}
