Lambda
====================

1. Given a list of Articles, `Cart` calculates the bill summing all the `Prices`;
2. `DiscountCart` applies a 50% discount to all articles whose `Price` is greater than 5 CHF;
3. With `FreeDrinkCart` all the drinks are for free;
4. With `PromotionCart` all the articles whouse `Price` is smaller than 2 CHF are given for free;
5. In `DiscountCart`, the discount and the threshold can be parametrized;
5. Remove all the duplicated code, applying the Strategy Pattern;
6. Replace theinterface and the 3 carts with a delegate and 3 methods;
7. Replace the 3 methods with local functions;
8. Replace local functions with a local delegate;
9. Replace the `delegate` in the cart constructor with a `Func`;
10. Simplify the syntax with a Lambda expression.

