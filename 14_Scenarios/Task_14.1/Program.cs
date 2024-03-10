namespace Task_14._1;

class Program
{
    static int _simpleValue;

    static async Task Main(string[] args)
    {
        var sharedInteger = new SharedResource<int>(() => _simpleValue++);
        var asyncSharedInteger = new AsyncLazy<int>(() => Task.Run(async () =>
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            return _simpleValue++;
        }));

        Console.WriteLine("Using SharedInteger:");
        for (int i = 0; i < 5; i++)
        {
            int value = sharedInteger.GetValue();
            Console.WriteLine($"SharedInteger value: {value}");
        }

        Console.WriteLine("\nUsing AsyncSharedInteger:");
        for (int i = 0; i < 5; i++)
        {
            int value = await asyncSharedInteger.GetValueAsync();
            Console.WriteLine($"AsyncSharedInteger value: {value}");
        }
    }
}