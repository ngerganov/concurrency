using System.Collections.Immutable;

namespace Task_9._4;

class Program
{
    static void Main(string[] args)
    {
        var immutableDictionaryCollection = ImmutableDictionary<int, string>.Empty;
        immutableDictionaryCollection = immutableDictionaryCollection.Add(10, "Ten");
        immutableDictionaryCollection = immutableDictionaryCollection.Add(21, "Twenty-One");
        immutableDictionaryCollection = immutableDictionaryCollection.SetItem(10, "Diez");
        foreach (var item in immutableDictionaryCollection)
        {
            Console.WriteLine(item.Key + item.Value);
        }
        
        Console.WriteLine($"Value at key 10: {immutableDictionaryCollection[10]}");
        immutableDictionaryCollection.Remove(21);
        foreach (var item in immutableDictionaryCollection)
        {
            Console.WriteLine(item.Key + item.Value);
        }

        var immutableSortedDictionaryCollection = ImmutableSortedDictionary<int, string>.Empty;
        immutableSortedDictionaryCollection = immutableSortedDictionaryCollection.Add(10, "Ten");
        immutableSortedDictionaryCollection = immutableSortedDictionaryCollection.Add(21, "Twenty-One");
        immutableSortedDictionaryCollection = immutableSortedDictionaryCollection.SetItem(10, "Diez");
        foreach (var item in immutableDictionaryCollection)
        {
            Console.WriteLine(item.Key + item.Value);
        }
        
        Console.WriteLine($"Value at key 10: {immutableSortedDictionaryCollection[10]}");
        immutableSortedDictionaryCollection.Remove(21);
        foreach (var item in immutableDictionaryCollection)
        {
            Console.WriteLine(item.Key + item.Value);
        }
    }
}