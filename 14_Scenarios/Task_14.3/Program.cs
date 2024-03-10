namespace Task_14._3;

class Program
{
    static void Main(string[] args)
    {
        var viewModel = new MyViewModel();

        viewModel.MyValue.PropertyChanged += (sender, e) =>
        {
            if (e.PropertyName == "Result")
            {
                Console.WriteLine($"MyValue.Result changed: {viewModel.MyValue.Result}");
            }
        };

        Console.ReadLine();
    }
}