using System.Collections.Immutable;

namespace Task_9._3;

public class ImmutableSetManager
{
    public ImmutableHashSet<int> CreateImmutableHashSet(params int[] numbers)
    {
        return ImmutableHashSet<int>.Empty.Union(numbers);
    }

    public ImmutableSortedSet<int> CreateImmutableSortedSet(params int[] numbers)
    {
        return ImmutableSortedSet<int>.Empty.Union(numbers);
    }

    public void PrintImmutableHashSet(ImmutableHashSet<int> hashSet)
    {
        foreach (var item in hashSet)
        {
            Console.WriteLine(item);
        }
    }

    public void PrintImmutableSortedSet(ImmutableSortedSet<int> sortedSet)
    {
        foreach (var item in sortedSet)
        {
            Console.WriteLine(item);
        }
    }
}