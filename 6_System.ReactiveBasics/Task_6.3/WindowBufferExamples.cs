using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Task_6._3;

public class WindowBufferExamples
{
    public static void RunWindowExample()
    {
        var subject = new Subject<long>();
        var windowExample = subject.Window(TimeSpan.FromSeconds(1));
        
        subject.OnNext(0);
        subject.OnNext(1);
        subject.OnNext(2);

        windowExample.Subscribe(group =>
        {
            Console.WriteLine($"{DateTime.Now.Second}: Starting new group");
            group.Subscribe(
                x => Console.WriteLine($"{DateTime.Now.Second}: Saw {x}"),
                () => Console.WriteLine($"{DateTime.Now.Second}: Ending group")
            );
        });

        subject.OnNext(3);
        subject.OnNext(4);
        subject.OnNext(5);

        Console.ReadLine();
    }

    public static void RunBufferExample()
    {
        var subject = new Subject<long>();
        var bufferExample = subject.Buffer(TimeSpan.FromSeconds(1));
        
        subject.OnNext(0);
        subject.OnNext(1);
        subject.OnNext(2);

        bufferExample.Subscribe(x =>
        {
            Console.WriteLine($"{DateTime.Now.Second}: Got {x[0]} and {x[1]}");
        });

        subject.OnNext(3);
        subject.OnNext(4);
        subject.OnNext(5);

        Console.ReadLine();
    }
}