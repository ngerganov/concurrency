using System.Collections.Immutable;

namespace Task_9._2;

class Program
{
    static void Main(string[] args)
    {
        ImmutableList<int> list = ImmutableList<int>.Empty;
        list = list.Insert(0, 13);
        list = list.Insert(0, 7);

        Console.WriteLine("Элементы в списке:");
        foreach (int item in list)
        {
            Console.WriteLine(item);
        }

        list = list.RemoveAt(1);

        Console.WriteLine("Элементы в списке после удаления:");
        foreach (int item in list)
        {
            Console.WriteLine(item);
        }
    }
}