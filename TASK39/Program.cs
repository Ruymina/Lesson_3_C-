// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// С циклом for
// void ReverseArray(int[] array)
// {
//     int size = array.Length;
//     int index1 = 0;
//     int index2 = size - 1;

//     while (index1 < index2)
//     {
//         int obj = array[index1]; //2
//         array[index1] = array[index2];
//         array[index2] = obj;

//         index1++;
//         index2--;
//     }
// }

// С циклом void
void ReverseArray2(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size / 2; i++)
    {
        Swap(array, i, array.Length - 1 - i);
    }
}

void Swap(int[] array, int index1, int index2)
{
    int temp = array[index1];
    array[index1] = array[index2];
    array[index2] = temp;
}