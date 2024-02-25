using System.Collections.Concurrent;

namespace Task_9._5;

public class ConcurrentDictionaryExample
{
    private readonly ConcurrentDictionary<int, string> _dictionary = new ConcurrentDictionary<int, string>();

    public void AddOrUpdateExample()
    {
        string newValue = _dictionary.AddOrUpdate(0,
            key => "Zero",
            (key, oldValue) => "Zero");
        Console.WriteLine($"Added or updated value: {newValue}");
    }

    public void ReadExample()
    {
        bool keyExists = _dictionary.TryGetValue(0, out string currentValue);
        Console.WriteLine($"Key exists: {keyExists}, Current value: {currentValue}");
    }

    public void RemoveExample()
    {
        bool keyExisted = _dictionary.TryRemove(0, out string removedValue);
        Console.WriteLine($"Key existed: {keyExisted}, Removed value: {removedValue}");
    }
}