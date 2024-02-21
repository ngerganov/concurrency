namespace Task4._1;

public class MatrixOperations : IMatrixOperations
{
    public void RotateMatrices(IEnumerable<Matrix> matrices, float degrees)
    {
        Parallel.ForEach(matrices, matrix => matrix.Rotate(degrees));
    }

    public void InvertMatrices(IEnumerable<Matrix> matrices)
    {
        Parallel.ForEach(matrices, (matrix, state) =>
        {
            if (!matrix.IsInvertible)
                state.Stop();
            else
                matrix.Invert();
        });
    }

    public int CountNonInvertibleMatrices(IEnumerable<Matrix> matrices)
    {
        object mutex = new object();
        int nonInvertibleCount = 0;
        Parallel.ForEach(matrices, matrix =>
        {
            if (!matrix.IsInvertible)
            {
                lock (mutex)
                {
                    nonInvertibleCount++;
                }
            }
        });
        return nonInvertibleCount;
    }
}