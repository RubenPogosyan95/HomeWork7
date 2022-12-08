//  Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  17 -> такого числа в массиве нет

Console.WriteLine("Select firstPossition from 0 to 2");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Select secondPossition from 0 to 3");
int b = Convert.ToInt32(Console.ReadLine());

CheckIndex(a, b, FillArray(3, 4));

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

void CheckIndex(int a, int b, int[,] array)
{
    if (a < array.GetLength(0) && a >= 0)
    {
        if (b < array.GetLength(1) && b >= 0)
        {
            Console.WriteLine("Your Number is - " + array[a, b]);
        }
    }
    else Console.WriteLine("Massive haven't this index");
}