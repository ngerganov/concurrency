namespace Task_14._7;

public class SolvingTask
{
    public string Solve(IProgress<int>? progress)
    {
        var endTime = DateTime.UtcNow.AddSeconds(3);
        int value = 0;
        
        while (DateTime.UtcNow < endTime)
        {
            value++;
            progress?.Report(value);
        }
        
        return value.ToString();
    }
}