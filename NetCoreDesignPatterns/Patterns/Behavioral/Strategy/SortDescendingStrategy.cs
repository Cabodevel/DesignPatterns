namespace NetCoreDesignPatterns.Patterns.Behavioral.Strategy
{
    internal class SortDescendingStrategy : ISortStrategy
    {
        public IOrderedEnumerable<string> Sort(IEnumerable<string> input)
         => input.OrderByDescending(i => i);
    }
}
