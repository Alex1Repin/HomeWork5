//Задача 36: Задайте одномерный массив, заполненный случайными
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] SummRandom(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}

var arr = SummRandom(9);
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{

    if (i % 2 == 1)
    {
        sum += arr[i];
    }
}

Console.WriteLine($"[{string.Join(", ", arr)}]");
Console.WriteLine(sum);