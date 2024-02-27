namespace Task_10._5;

public class CancellationExample
{
    public static void RotateMatrices(IEnumerable<Matrix> matrices, float degrees, CancellationToken token)
    {
        Parallel.ForEach(matrices,
            new ParallelOptions { CancellationToken = token },
            matrix => matrix.Rotate(degrees));
    }
    
    public static void RotateMatrices2(IEnumerable<Matrix> matrices, float degrees, CancellationToken token)
    {
        Parallel.ForEach(matrices, matrix =>
        {
            matrix.Rotate(degrees);
            token.ThrowIfCancellationRequested();
        });
    }
    
    public static IEnumerable<int> MultiplyBy2(IEnumerable<int> values, CancellationToken cancellationToken)
    {
        return values.AsParallel()
            .WithCancellation(cancellationToken)
            .Select(item => item * 2);
    }
}