using System.Collections.Immutable;

namespace Task_9._1;

class Program
{
    static void Main(string[] args)
    {
        ImmutableStackExample();
        ImmutableQueueExample();
    }
    
    static void ImmutableStackExample()
    {
        ImmutableStack<int> stack = ImmutableStack<int>.Empty;
        stack = stack.Push(13);
        stack = stack.Push(7);

        Console.WriteLine("Вывод неизменяемого стека: ");
        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }

        stack.Pop(out var lastItem);
        Console.WriteLine("Последний элемент, извлеченный из неизменяемого стека: " + lastItem);
    }

    static void ImmutableQueueExample()
    {
        ImmutableQueue<int> queue = ImmutableQueue<int>.Empty;
        queue = queue.Enqueue(13);
        queue = queue.Enqueue(7);

        Console.WriteLine("Вывод неизменяемой очереди: ");
        foreach (int item in queue)
        {
            Console.WriteLine(item);
        }

        queue.Dequeue(out var nextItem);
        Console.WriteLine("Следующий элемент исключен из неизменяемой очереди: " + nextItem);
    }
}