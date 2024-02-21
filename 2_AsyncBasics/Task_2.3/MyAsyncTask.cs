namespace Task2._3;

public class MyAsyncTask
{
    public async Task MyMethodAsync(IProgress<double> progress = null)
    {
        bool done = false;
        double percentComplete = 0;
        while (!done)
        {
            percentComplete += 10;
            progress?.Report(percentComplete);

            if (percentComplete >= 100)
                done = true;

            await Task.Delay(1000);
        }
    }
}