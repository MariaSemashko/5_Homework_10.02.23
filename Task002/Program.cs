﻿/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] InitArray(int dimention)
{
    int[] result = new int[dimention];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-10,11);
    }

    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int GetSumOddPos(int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 != 0) sum = sum + arr[i];
    }
    return sum;
}


int [] arr = InitArray(4);
PrintArray(arr);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {GetSumOddPos(arr)}");
