//Задача 38: Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] RRandom(int num)
{
    double[] array = new double[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100)/10.0;
    }
    return array;
}

double DivMinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    double result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        if (arr[i] > max)
        {
            max = arr[i];
        }    
    }
    result = max - min;
    return result;
}

double[] arr = RRandom(9);
Console.WriteLine($"[{string.Join(", ", arr)}]");
Console.WriteLine(DivMinMax(arr));