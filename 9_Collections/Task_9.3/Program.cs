using System.Collections.Immutable;

namespace Task_9._3;

class Program
{
    static void Main(string[] args)
    {
        ImmutableSetManager setManager = new ImmutableSetManager();

        ImmutableHashSet<int> hashSet = setManager.CreateImmutableHashSet(13, 7, 5, 13);
        Console.WriteLine("ImmutableHashSet: ");
        setManager.PrintImmutableHashSet(hashSet);

        hashSet = hashSet.Remove(7);
        Console.WriteLine("После удаления 7: ");
        setManager.PrintImmutableHashSet(hashSet);

        ImmutableSortedSet<int> sortedSet = setManager.CreateImmutableSortedSet(13, 7, 5, 13);
        Console.WriteLine("ImmutableSortedSet: ");
        setManager.PrintImmutableSortedSet(sortedSet);

        int smallestItem = sortedSet.Min;
        Console.WriteLine("Самое маленькое значение в отсортированном наборе: " + smallestItem);

        sortedSet = sortedSet.Remove(7);
        Console.WriteLine("После удаления 7 из отсортированного набора: ");
        setManager.PrintImmutableSortedSet(sortedSet);
    }
}