// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
PrintFibonacci(number);

void PrintFibonacci(int num)
{
    int firstNum = 0;
    int secondNum = 1;
    System.Console.Write($"{firstNum} {secondNum} ");
    for (int i = 2; i < num; i++)
    {
        int nextNum = firstNum + secondNum;
        System.Console.Write($"{nextNum} ");
        firstNum = secondNum;
        secondNum = nextNum;
    }


    // Реализация через массивы
    int[] CopyArray(int[] array)
    {
        int[] newArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i];
        }
        return newArray;
    }

    int[] arr = CreateArrayRndInt(5, 1, 9);
    int[] copyArray = CopyArray(arr);
    copyArray[0] = 99;
    PrintArray(arr);
    PrintArray(copyArray);