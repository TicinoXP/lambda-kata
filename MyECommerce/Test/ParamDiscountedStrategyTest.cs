using FluentAssertions;
using MyECommerce.Cart;
using MyECommerce.Strategies;
using Xunit;

namespace MyECommerce.Test
{
    public class ParamDiscountedStrategyTest
    {
        public ParamDiscountedStrategyTest()
        {
            _strategy = new ParamDiscountedStrategy(5m, Discount);
        }

        private const decimal Discount = 0.5m;
        private readonly IPricingStrategy _strategy;

        [Fact]
        public void should_calculare_discounted_price_when_price_greater_than_5()
        {
            _strategy.CalculatePrice(new Article {Price = 10m}).Should().Be(10 - 10 * Discount);
        }

        [Fact]
        public void should_calculare_Not_discounted_price_when_price_equal_to_5()
        {
            _strategy.CalculatePrice(new Article {Price = 5m}).Should().Be(5m);
        }

        [Fact]
        public void should_calculare_Not_discounted_price_when_price_less_than_5()
        {
            _strategy.CalculatePrice(new Article {Price = 4m}).Should().Be(4m);
        }
    }
}