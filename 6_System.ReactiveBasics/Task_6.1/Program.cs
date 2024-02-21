namespace Task_6._1;

class Program
{
    static void Main(string[] args)
    {
        ObservableEventProcessor eventProcessor = new ObservableEventProcessor();

        var progress = new CustomProgress<int>();

        var progressReports = eventProcessor.FromEventPattern<int>(
            handler => progress.ProgressChanged += handler,
            handler => progress.ProgressChanged -= handler
        );

        progressReports.Subscribe(data =>
        {
            Console.WriteLine($"OnNext: {data.EventArgs}");
        });

        progress.Report(10);
        progress.Report(20);
        progress.Report(30);

        Console.WriteLine();

        var timer = new System.Timers.Timer(interval: 1000) { Enabled = true };
        var ticks = eventProcessor.FromEventPattern(timer, nameof(System.Timers.Timer.Elapsed));

        ticks.Subscribe(data =>
        {
            var eventArgs = (System.Timers.ElapsedEventArgs)data.EventArgs;
            Console.WriteLine($"OnNext: {eventArgs.SignalTime}");
        });
    }
}