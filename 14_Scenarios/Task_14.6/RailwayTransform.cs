using System.Threading.Tasks.Dataflow;

namespace Task_14._6;

public static class RailwayTransform
{
    public static TransformBlock<Try<TInput>, Try<TOutput>> CreateTransformBlock<TInput, TOutput>(Func<TInput, TOutput> func)
    {
        return new TransformBlock<Try<TInput>, Try<TOutput>>(t => t.Map(func));
    }
}