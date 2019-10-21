using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        //1. The correct default price, calories, ice, size, and SpaceForCream properties.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(.59, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }

        [Fact]

        public void ShouldHaveDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }

        [Fact]
        public void ShouldHaveDefaultSpaceForCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.RoomForCream);
        }

        //2. The correct price and calories after changing to small, medium, and large sizes.

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<double>(.59, java.Price);

        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(.99, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }
        //3. That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void ShouldAddIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }
        //4. That invoking LeaveSpaceForCream() results in the SpaceForCream property being true.
        [Fact]
        public void LeaveSpaceForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }

        //Beginning of Notification Tests

        [Fact]
        public void DescriptionShouldBeCorrectForSizeSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            Assert.Equal("Small Jurassic Java", java.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal("Medium Jurassic Java", java.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal("Large Jurassic Java", java.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeSmallAndDecaf()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            java.Decaf = true;
            Assert.Equal("Small Decaf Jurassic Java", java.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeMediumAndDecaf()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Decaf = true;
            Assert.Equal("Medium Decaf Jurassic Java", java.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeLargeAndDecaf()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            java.Decaf = true;
            Assert.Equal("Large Decaf Jurassic Java", java.Description);
        }

        [Fact]
        public void SpecialShouldbeEmptyByDefault()
        {
            JurassicJava java = new JurassicJava();
            Assert.Empty(java.Special);
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeSmall()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Description", () =>
            {
                java.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeMedium()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Description", () =>
            {
                java.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeLarge()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Description", () =>
            {
                java.Size = Size.Large;
            });
        }

        [Fact]
        public void AddIceShouldAddToSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.Collection<string>(java.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            });
        }

        [Fact]
        public void LeaveRoomForCreamShouldAddToSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.Collection<string>(java.Special, item =>
            {
                Assert.Equal("Leave Room For Cream", item);
            });
        }

        [Fact]
        public void AddIceShouldNotifySpecialChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.AddIce();
            });
        }

        [Fact]
        public void LeaveRoomForCreamShouldNotifySpecialChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.LeaveRoomForCream();
            });
        }
    }
}
