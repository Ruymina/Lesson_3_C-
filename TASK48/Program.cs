// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.WriteLine("Введите размер массива m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива n ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myMatrix = CreateMatrixSumIndex(m, n);
PrintMatrix(myMatrix);

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}
int[,] CreateMatrixSumIndex(int rows, int colums);
{
    int[,] arr = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            arr[i, j] = i + j;
        }
    }
    return arr;
}