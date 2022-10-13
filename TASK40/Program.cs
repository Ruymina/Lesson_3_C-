// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.WriteLine("Дорогой пользователь, введите число");
int number = Convert.ToInt32(Console.ReadLine());
int binaryNumUnreversed = ConvertNumberToBinary(number);
Console.WriteLine($"{number} -> {binaryNumUnreversed}");
int ConvertNumberToBinary(int num)
{
    int binaryNumUnreversed = 0;
    int count = 1;
    while (num > 0)
    {
        binaryNumUnreversed = binaryNumUnreversed + num % 2 * count;
        count = count * 10;
        num = num / 2;
    }
 
    return binaryNumUnreversed;
}