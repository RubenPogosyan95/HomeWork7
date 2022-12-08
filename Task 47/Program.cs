// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Select hight of matrix");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Select lenght of matrix");
int n = Convert.ToInt32(Console.ReadLine());

void FillArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11) + new Random().NextDouble();
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
}
FillArray(m, n);