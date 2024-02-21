namespace Task4._1;

class Program
{
    static void Main(string[] args)
    {
        IMatrixOperations matrixOperations = new MatrixOperations();
        List<Matrix> matrices = GenerateMatrices();

        Console.WriteLine("Rotating Matrices:");
        matrixOperations.RotateMatrices(matrices, 90);
        PrintMatrices(matrices);

        Console.WriteLine("\nInverting Matrices:");
        matrixOperations.InvertMatrices(matrices);
        PrintMatrices(matrices);

        Console.WriteLine($"\nNumber of Non-invertible Matrices: {matrixOperations.CountNonInvertibleMatrices(matrices)}");
    }

    static List<Matrix> GenerateMatrices()
    {
        Random random = new Random();
        List<Matrix> matrices = new List<Matrix>();

        for (int i = 0; i < 5; i++)
        {
            matrices.Add(new Matrix(random.Next(2, 5), random.Next(2, 5)));
        }

        return matrices;
    }

    static void PrintMatrices(IEnumerable<Matrix> matrices)
    {
        foreach (var matrix in matrices)
        {
            Console.WriteLine(matrix);
        }
    }
}