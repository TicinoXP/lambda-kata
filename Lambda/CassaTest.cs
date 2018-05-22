using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Lambda
{
  public class CassaTest
  {
    private readonly Cassa _sut;

    public CassaTest()
    {
      _sut = new Cassa();
    }

    [Fact]
    public void should_sum_values()
    {
      var cart = new List<Article>
        {
          new Article{ Name = "spaghetti", Category = "primo", Prezzo = 13},
          new Article{ Name = "cotoletta", Category = "secondo", Prezzo = 6},
          new Article{ Name = "insalata", Category = "contorno", Prezzo = 6},
          new Article{ Name = "tic-tac", Category = "candies", Prezzo = 2},
          new Article{ Name = "estathe", Category = "drinks", Prezzo = 4}
        };

      var totale = _sut.Calcola(cart);

      totale.Should().Be("Lei spende 31 franchi");
    }
  }

  public class Cassa
  {
    public string Calcola(List<Article> cart)
    {
      decimal totale = 0;
      foreach (var article in cart)
      {
        totale += article.Prezzo;
      }

      return $"Lei spende {totale} franchi";
    }
  }

  public class Article
  {
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Prezzo { get; set; }
  }

  class MyClass
  {
    
  }
}
