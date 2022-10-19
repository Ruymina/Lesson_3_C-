// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
System.Console.WriteLine();

GetSquareEvenElem(array2D);
PrintMatrix(array2D);

// метод возведение чётных элементов массива в квадрат
void GetSquareEvenElem(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2) //rows (0)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2) //columns (1)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}