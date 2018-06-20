using FluentAssertions;
using MyECommerce.Cart;
using MyECommerce.Strategies;
using Xunit;

namespace MyECommerce.Test
{
    public class BasePriceStrategyTest
    {
        [Fact]
        public void should_calculare_basic_price()
        {
            new BasePriceStrategy().CalculatePrice(new Article {Price = 10m}).Should().Be(10m);
        }
    }
}