using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        
        //1. The correct default price, calories, ice, size, lemon, and sweet properties.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(.99, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        [Fact]

        public void ShouldHaveDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }

        [Fact]

        public void ShouldHaveDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.lemon);
        }

        [Fact]
        public void ShouldHaveDefaultSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sweet);
        }
        //2. The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<double>(.99, tea.Price);

        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }
        //3. That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void ShouldHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }
        //4. That invoking AddLemon() sets results in the Lemon property being true.
        [Fact]
        public void ShouldAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.lemon);
        }
        //5. That setting the sweet property to true results in the right calories for each size
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmallAndSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<uint>(16, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMediumAndSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Medium;
            Assert.Equal<uint>(32, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLargeAndSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Large;
            Assert.Equal<uint>(64, tea.Calories);
        }
        //6. That setting the sweet property to false (after it has been set to true) results in the right calories for each size.

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmallAndNotSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            tea.Sweet = false;
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMediumAndNotSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Medium;
            tea.Sweet = false;
            Assert.Equal<uint>(16, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLargeAndNotSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Large;
            tea.Sweet = false;
            Assert.Equal<uint>(32, tea.Calories);
        }

        //Beginning of Notification Tests

        [Fact]
        public void DescriptionShouldBeCorrectForSizeSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            Assert.Equal("Small Tyrannotea", tea.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal("Medium Tyrannotea", tea.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal("Large Tyrannotea", tea.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeSmallAndSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            tea.Sweet = true;
            Assert.Equal("Small Sweet Tyrannotea", tea.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeMediumAndSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Sweet = true;
            Assert.Equal("Medium Sweet Tyrannotea", tea.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSizeLargeAndSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Sweet = true;
            Assert.Equal("Large Sweet Tyrannotea", tea.Description);
        }

        [Fact]
        public void SpecialShouldbeEmptyByDefault()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Empty(tea.Special);
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Description", () =>
            {
                tea.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Description", () =>
            {
                tea.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifySpecialChangeForSizeLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Description", () =>
            {
                tea.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSweetShouldNotifySpecialChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Description", () =>
            {
                tea.Sweet = true;
            });
        }

        [Fact]
        public void HoldIceShouldAddToSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.Collection<string>(tea.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }

        [Fact]
        public void AddLemonShouldAddToSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Collection<string>(tea.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }

        [Fact]
        public void HoldIceShouldNotifySpecialChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () =>
            {
                tea.HoldIce();
            });
        }

        [Fact]
        public void AddLemonShouldNotifySpecialChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () =>
            {
                tea.AddLemon();
            });
        }
    }
}
