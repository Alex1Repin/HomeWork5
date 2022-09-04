//Задача 34: Задайте массив заполненный случайными положительными
//трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] ThreeRandom(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

var arr = ThreeRandom(9);
int count = 0;

foreach (var item in arr)
{
    if ( item % 2 == 0)
    {
        count ++;
    }
}

Console.WriteLine($"[{string.Join(", ", arr)}]");
Console.WriteLine(count);