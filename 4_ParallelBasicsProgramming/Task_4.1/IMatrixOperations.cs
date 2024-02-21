namespace Task4._1;

public interface IMatrixOperations
{
    void RotateMatrices(IEnumerable<Matrix> matrices, float degrees);
    void InvertMatrices(IEnumerable<Matrix> matrices);
    int CountNonInvertibleMatrices(IEnumerable<Matrix> matrices);
}