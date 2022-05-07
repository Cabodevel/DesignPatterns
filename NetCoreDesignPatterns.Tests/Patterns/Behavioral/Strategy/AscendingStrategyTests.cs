using NetCoreDesignPatterns.Patterns.Behavioral.Strategy;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace NetCoreDesignPatterns.Tests.Patterns.Behavioral.Strategy
{
    public class AscendingStrategyTests
    {
        private readonly ISortStrategy _sut;
        public AscendingStrategyTests()
        {
            _sut = new SortAscendingStrategy();
        }


        [Fact]
        public void Given_IEnumerable_Should_Return_IEnumerable()
        {
            var items = new List<string>();

            var orderedItems = _sut.Sort(items);

            Assert.NotNull(orderedItems);
            Assert.IsAssignableFrom<IEnumerable<string>>(orderedItems);
        }

        [Fact]
        public void Given_NotOrdered_IEnumerable_Should_Return_Ordered_IEnumerable()
        {
            var items = new List<string> { "b", "c", "a"};
            var expectedFirst = "a";
            var expectedLast = "c";

            var orderedItems = _sut.Sort(items);

            Assert.IsAssignableFrom<IEnumerable<string>>(orderedItems);

            Assert.Equal(orderedItems.First(), expectedFirst);
            Assert.Equal(orderedItems.Last(), expectedLast);
        }
    }
}
