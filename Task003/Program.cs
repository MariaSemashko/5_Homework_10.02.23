/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] InitArray(int dimention)
{
    double[] result = new double[dimention];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-10,11);
    }

    return result;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double GetDiff(double[] arr)
{
    double max = arr[0];
    double min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }

    return max - min;
}

double [] arr = InitArray(10);
PrintArray(arr);

Console.WriteLine($"Разность между максимальным и минимальным элементов массива = {GetDiff(arr)}");