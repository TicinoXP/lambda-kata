using MyECommerce.Cart;

namespace MyECommerce.Strategies
{
    public class BasePriceStrategy : IPricingStrategy
    {
        public decimal CalculatePrice(Article article)
        {
            return article.Price;
        }
    }
}