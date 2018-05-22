using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Lambda
{
  public class CartTest
  {
    [Fact]
    public void should_calculate_bill_with_no_discount()
    {
      var cart = new Cart();

      var articles = new List<Article>
        {
          new Article{ Name = "spaghetti", Category = "courses", Price = 20},
          new Article{ Name = "cotoletta", Category = "courses", Price = 10},
          new Article{ Name = "salad", Category = "courses", Price = 6},
          new Article{ Name = "water", Category = "drinks", Price = 2},
          new Article{ Name = "estathe", Category = "drinks", Price = 4},
          new Article{ Name = "sambuca", Category = "spirits", Price = 8}
        };

      var totale = cart.CalculateBill(articles);

      totale.Should().Be("It's 31 Francs, madam!");
    }
  }

  public class Article
  {
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
  }

  public class Cart
  {
    public string CalculateBill(List<Article> articles)
    {
      throw new NotImplementedException();
    }
  }
}
