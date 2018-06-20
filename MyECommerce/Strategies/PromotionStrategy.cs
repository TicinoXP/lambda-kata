using MyECommerce.Cart;

namespace MyECommerce.Strategies
{
    public class PromotionStrategy : IPricingStrategy
    {
        public decimal CalculatePrice(Article article)
        {
            if (article.Price < 2) return 0m;

            return article.Price;
        }
    }
}