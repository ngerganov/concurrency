namespace Task_12._5;

public class MatrixProcessor
{
    public void RotateMatrices(IEnumerable<Matrix> matrices, float degrees)
    {
        var options = new ParallelOptions
        {
            MaxDegreeOfParallelism = 10
        };

        Parallel.ForEach(matrices, options, matrix => matrix.Rotate(degrees));
    }
}