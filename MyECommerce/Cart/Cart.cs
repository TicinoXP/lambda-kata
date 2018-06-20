using System.Collections.Generic;
using MyECommerce.Strategies;

namespace MyECommerce.Cart
{
    public class Cart
    {
        private readonly IPricingStrategy _basePriceStrategy;

        public Cart(IPricingStrategy basePriceStrategy)
        {
            _basePriceStrategy = basePriceStrategy;
        }

        public string CalculateBill(List<Article> articles)
        {
            var sum = 0m;
            foreach (var article in articles) sum += _basePriceStrategy.CalculatePrice(article);
            return $"It's {sum} Francs, madam!";
        }
    }
}