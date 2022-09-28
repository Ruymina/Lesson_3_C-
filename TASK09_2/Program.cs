// Задача 9. Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99] и
// 2. показывает наибольшую цифру числа

// 78 -> 8
// 12-> 2
// 85 -> 8
// 99 -> цифры равны

Console.Clear();

int number = new Random().Next(10, 100);
int Max = 0;

int MaxDigit()
{
    int DigitOne = number / 10;
    int DigitTwo = number % 10;
    if (DigitOne > DigitTwo) Max = DigitOne;
    else Max = DigitTwo;

    return Max;
}

MaxDigit();
System.Console.WriteLine();
System.Console.WriteLine($"В числе {number} наибольшая цифра {Max}");
System.Console.WriteLine();

int MaxDigit(int num)
{
int firstDigit = num / 10;
int secondDigit = num % 10;
// if (firstDigit > secondDigit) return firstDigit;
// return secondDigit;
if(IsEqualDigits(firstDigit, secondDigit)) return 0;
return firstDigit > secondDigit ? firstDigit : secondDigit;
}

bool IsEqualDigits(int num1, int num2)
{
return num1 == num2;
}

int number = new Random().Next(10, 100);
int maxDigit = MaxDigit (number);

string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры равны";
Console.WriteLine($"Наибольшая цифра числа {number} = {maxDigit}");