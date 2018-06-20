using FluentAssertions;
using MyECommerce.Cart;
using MyECommerce.Strategies;
using Xunit;

namespace MyECommerce.Test
{
    public class DiscountedStrategyTest
    {
        [Fact]
        public void should_calculare_full_price_when_price_equal_to_5()
        {
            new DisocuntedStrategy().CalculatePrice(new Article {Price = 5m}).Should().Be(5m);
        }

        [Fact]
        public void should_calculare_full_price_when_price_less_than_5()
        {
            new DisocuntedStrategy().CalculatePrice(new Article {Price = 4m}).Should().Be(4m);
        }

        [Fact]
        public void should_calculare_half_price_when_price_greater_than_5()
        {
            new DisocuntedStrategy().CalculatePrice(new Article {Price = 10m}).Should().Be(5m);
        }
    }
}