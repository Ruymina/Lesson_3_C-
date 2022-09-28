// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.WriteLine();

int number = new Random().Next(1, 1500);
Console.WriteLine();
Console.WriteLine($"Дано число: {number}");

if (number / 100 > 0) System.Console.WriteLine($"Третьей цифрой числа {number} является цифра {number / 100 % 10}");
else Console.WriteLine($"У числа {number} нет третьей цифры");

Console.WriteLine();
