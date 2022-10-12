// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int QuantityElemInRange(int[] array, int min, int max)
{
    int counter = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max) counter++;
    }
    return counter;
}

int[] arr = CreateArrayRndInt(10, 0, 1000);
PrintArray(arr);
int quantityElemInRange = QuantityElemInRange(arr, 10, 99);
Console.WriteLine(quantityElemInRange);
// разобраться почему ошибка