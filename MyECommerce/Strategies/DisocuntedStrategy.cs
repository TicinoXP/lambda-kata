using MyECommerce.Cart;

namespace MyECommerce.Strategies
{
    public class DisocuntedStrategy : IPricingStrategy
    {
        public decimal CalculatePrice(Article article)
        {
            if (article.Price <= 5)
                return article.Price;

            return article.Price - article.Price * 0.5m;
        }
    }
}