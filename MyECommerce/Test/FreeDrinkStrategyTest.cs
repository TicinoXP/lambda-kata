using FluentAssertions;
using MyECommerce.Cart;
using MyECommerce.Strategies;
using Xunit;

namespace MyECommerce.Test
{
    public class FreeDrinkStrategyTest
    {
        [Fact]
        public void should_calculare_basic_price_when_article_is_not_a_drink()
        {
            new FreeDrinkStrategy().CalculatePrice(new Article {Category = "something else", Price = 10m}).Should()
                .Be(10m);
        }

        [Fact]
        public void should_calculare_free_price_when_article_is_a_drink()
        {
            new FreeDrinkStrategy().CalculatePrice(new Article {Category = "drinks", Price = 10m}).Should().Be(0m);
        }
    }
}