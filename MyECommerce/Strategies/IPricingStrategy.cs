using MyECommerce.Cart;

namespace MyECommerce.Strategies
{
    public interface IPricingStrategy
    {
        decimal CalculatePrice(Article article);
    }
}