using FluentAssertions;
using Xunit;

namespace Lambda
{
  public class DummyTest
  {
    [Fact]
    public void should_pass()
    {
      "friends".Should().Be("friends");
    }
  }
}
