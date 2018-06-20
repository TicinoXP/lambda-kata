using FluentAssertions;
using MyECommerce.Cart;
using MyECommerce.Strategies;
using Xunit;

namespace MyECommerce.Test
{
    public class PromotionStrategyTest
    {
        [Fact]
        public void should_calculare_price_with_promotion_when_price_is_less_than_2()
        {
            new PromotionStrategy().CalculatePrice(new Article {Price = 1m}).Should().Be(0m);
        }

        [Fact]
        public void should_calculare_price_without_promotion_when_price_is_equal_to_2()
        {
            new PromotionStrategy().CalculatePrice(new Article {Price = 2m}).Should().Be(2m);
        }

        [Fact]
        public void should_calculare_price_without_promotion_when_price_is_greater_than_2()
        {
            new PromotionStrategy().CalculatePrice(new Article {Price = 10m}).Should().Be(10m);
        }
    }
}