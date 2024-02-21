namespace Task4._4;

class Program
{
    static void Main(string[] args)
    {
        Node root = new Node();

        TreeProcessor.ProcessTree(root);
        Console.WriteLine("Tree processing completed.");
    }
}