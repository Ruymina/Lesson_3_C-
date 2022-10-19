// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Вариант решения №1
// Console.WriteLine($"Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце ");

// int[,] arrayWhole = new int[m, n];
// arrayWhole = TransformationArrayWhole(array);

// WriteArrayInt(arrayWhole);

// Console.Write($"\nCреднее арифметическое:\n");
// for (int i = 0; i < n; i++)
// {
//     double arithmeticMean = 0;
//     for (int j = 0; j < m; j++)
//     {
//         arithmeticMean += arrayWhole[j, i];
//     }
//     arithmeticMean = Math.Round(arithmeticMean / m, 1);
//     Console.WriteLine($"столбца № {i + 1} {arithmeticMean}");
// }

// int[,] TransformationArrayWhole(double[,] array)
// {
//     int[,] arrayWhole = new int[array.GetLength(0), array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             arrayWhole[i, j] = Convert.ToInt32(array[i, j]);
//         }
//     }4
//     return arrayWhole;
// }

// void WriteArrayInt(int[,] arrayWhole)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Console.Write(arrayWhole[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }


// Вариант решения №2

Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}