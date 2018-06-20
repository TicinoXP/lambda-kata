using MyECommerce.Cart;

namespace MyECommerce.Strategies
{
    public class FreeDrinkStrategy : IPricingStrategy
    {
        public decimal CalculatePrice(Article article)
        {
            return article.Category == "drinks" ? 0m : article.Price;
        }
    }
}