using System.Collections.Generic;
using FluentAssertions;
using MyECommerce.Cart;
using MyECommerce.Strategies;
using Xunit;

namespace MyECommerce.Test
{
    public class CartTest
    {
        [Fact]
        public void should_calculate_bill_as_sum_of_all_prices()
        {
            // Se introduciamo i MOCK, potremmo genericamente programmare un mock invece di usare una implementazione concreta di una delle nostre strategie
            var cart = new Cart.Cart(new BasePriceStrategy());

            var articles = new List<Article>
            {
                new Article {Name = "spaghetti", Category = "courses", Price = 20},
                new Article {Name = "cotoletta", Category = "courses", Price = 10},
                new Article {Name = "salad", Category = "courses", Price = 6},
                new Article {Name = "water", Category = "drinks", Price = 2},
                new Article {Name = "estathe", Category = "drinks", Price = 4},
                new Article {Name = "sambuca", Category = "spirits", Price = 8}
            };

            var totale = cart.CalculateBill(articles);

            totale.Should().Be("It's 50 Francs, madam!");
        }
    }
}