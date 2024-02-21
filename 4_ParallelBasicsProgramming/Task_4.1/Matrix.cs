namespace Task4._1;

public class Matrix
{
    private int[,] _data;

    public Matrix(int rows, int columns)
    {
        _data = new int[rows, columns];
    }

    public bool IsInvertible
    {
        get
        {
            // Проверка, является ли матрица обратимой
            // Примечание: просто заглушка, реальная логика должна быть реализована
            return true;
        }
    }

    public void Rotate(float degrees)
    {
        // Реализация вращения матрицы
        Console.WriteLine($"Rotating matrix by {degrees} degrees.");
    }

    public void Invert()
    {
        // Реализация инвертирования матрицы
        Console.WriteLine("Inverting matrix.");
    }

    public override string ToString()
    {
        // Реализация метода ToString для вывода матрицы в консоль
        return "Matrix";
    }
}