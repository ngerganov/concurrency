namespace Task4._5;

class Program
{
    static void Main(string[] args)
    {
        DataProcessor processor = new DataProcessor();
        var values = Enumerable.Range(1, 10);

        var multipliedValues = processor.MultiplyBy2(values);
        var multipliedValuesOrdered = processor.MultiplyBy2Ordered(values);
        var sum = processor.ParallelSum(values);

        Console.WriteLine("Значения, умноженные на 2 параллельно:");
        foreach (var value in multipliedValues)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Значения, умноженные на 2 параллельно с сохранением порядка:");
        foreach (var value in multipliedValuesOrdered)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Сумма значений, рассчитанных параллельно:" + sum);
    }
}