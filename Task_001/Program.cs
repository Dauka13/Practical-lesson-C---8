// Найти произведение двух матриц

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            result[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return result;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int rows = 3;
int columns = 4;

int[,] matrix1 = CreateMatrix(rows, columns, 1, 10);
int[,] matrix2 = CreateMatrix(rows, columns, 10, 20);
int[,] result = MultiplicationMatrix(matrix1, matrix2);
PrintMatrix(matrix1);
Console.WriteLine("* * * * ");
PrintMatrix(matrix2);
Console.WriteLine("= = = = = =");
PrintMatrix(result);