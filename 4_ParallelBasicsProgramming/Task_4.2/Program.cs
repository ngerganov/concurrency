namespace Task4._2;

class Program
{
    static void Main(string[] args)
    {
        IParallelOperations parallelOperations = new ParallelOperations();
        List<int> values = GenerateValues();

        int sum = parallelOperations.ParallelSum(values);
        Console.WriteLine($"Parallel Sum: {sum}");
    }

    static List<int> GenerateValues()
    {
        Random random = new Random();
        List<int> values = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            values.Add(random.Next(1, 101));
        }

        return values;
    }
}