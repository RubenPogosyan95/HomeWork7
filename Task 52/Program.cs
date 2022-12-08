// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Select hight of martix");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Select lenght of matrix");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

FindArithmetic(FillArray(m, n));


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

void FindArithmetic(int[,] array)
{
    Console.Write("The Arithmetic of numbers = ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        float sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum+= array[i, j];    
        }
        Console.Write("<" + sum / array.GetLength(0) + "> ");
    }
}