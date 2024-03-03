namespace Task_11._3;

class Program
{
    static async Task Main(string[] args)
    {
        var fundamentalType = new MyFundamentalType();

        var composedType = new MyComposedType(fundamentalType);

        await AsyncInitialization.WhenAllInitializedAsync(fundamentalType, composedType);
    }
}