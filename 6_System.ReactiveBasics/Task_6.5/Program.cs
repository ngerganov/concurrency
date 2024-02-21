using System.Reactive.Linq;

namespace Task_6._5;

class Program
{
    public static async Task Main(string[] args)
    {
        var reactiveExample = new ReactiveTimeoutExample();

        Console.WriteLine("Запуск задачи с тайм-аутом...");
        await reactiveExample.GetWithTimeoutAsync();

        Console.WriteLine("Задача с тайм-аутом завершена.");

        Console.ReadLine();
    }
}