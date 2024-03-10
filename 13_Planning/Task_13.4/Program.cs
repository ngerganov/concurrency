namespace Task_13._4;

class Program
{
    static void Main(string[] args)
    {
        DataFlowNetwork dataFlowNetwork = new DataFlowNetwork();

        dataFlowNetwork.PostData(5);
        dataFlowNetwork.PostData(10);
        dataFlowNetwork.PostData(15);
        
        Console.ReadLine();
    }
}