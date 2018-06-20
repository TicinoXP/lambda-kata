using MyECommerce.Cart;

namespace MyECommerce.Strategies
{
    public class ParamDiscountedStrategy : IPricingStrategy
    {
        private readonly decimal _discount;
        private readonly decimal _threshold;

        public ParamDiscountedStrategy(decimal threshold, decimal discount)
        {
            _threshold = threshold;
            _discount = discount;
        }

        public decimal CalculatePrice(Article article)
        {
            if (article.Price <= _threshold)
                return article.Price;

            return article.Price - article.Price * _discount;
        }
    }
}