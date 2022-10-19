// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] myArray = CreateMatrix(4, 3, 1, 9);
PrintMatrix(myArray);
Console.WriteLine();
Console.WriteLine($"{SummOfEqualIndex(myArray)}");


int SummOfEqualIndex(int[,] matrix)
{
    int sum = default;
    int targetSize = 0;
    if (matrix.GetLength(0) > matrix.GetLength(1)) targetSize = 1;
    for (int i = 0; i < matrix.GetLength(targetSize); i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}