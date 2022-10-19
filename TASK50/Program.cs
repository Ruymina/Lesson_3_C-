// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

// Вариант решения №1

// Console.WriteLine($"!Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");

// Console.Write("\nMассив возьмем из предыдущей задачи (№ 47).\n");
// Console.Write("Введите координаты позиции элемента, разделенных запятой: ");

// string? positionElement = Console.ReadLine();
// positionElement = RemovingSpaces(positionElement);
// int[] position = ParserString(positionElement);

// if (position[0] <= m
// && position[1] <= n
// && position[0] >= 0
// && position[1] >= 0)
// {
//     double result = array[position[0] - 1, position[1] - 1];
//     Console.Write($"Значение элемента: {result}");
// }
// else Console.Write($"такого элемента в массиве нет.");

// int[] ParserString(string input)
// {
//     int countNumbers = 1;
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ',')
//             countNumbers++;
//     }

//     int[] numbers = new int[countNumbers];

//     int numberIndex = 0;
//     for (int i = 0; i < input.Length; i++)
//     {
//         string subString = String.Empty;

//         while (input[i] != ',')
//         {
//             subString += input[i].ToString();
//             if (i >= input.Length - 1)
//                 break;
//             i++;
//         }
//         numbers[numberIndex] = Convert.ToInt32(subString);
//         numberIndex++;
//     }

//     return numbers;
// }

// string RemovingSpaces(string input)
// {
//     string output = String.Empty;
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] != ' ')
//         {
//             output += input[i];
//         }
//     }
//     return output;
// }

// Вариант решения №2

Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[10, 10];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n - 1, m - 1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10;
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