namespace NetCoreDesignPatterns.Patterns.Behavioral.Strategy
{
    public interface ISortStrategy
    {
        IOrderedEnumerable<string> Sort(IEnumerable<string> input);
    }
}
