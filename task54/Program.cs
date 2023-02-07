// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.

Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int[,] arr = Generate2DArray(n, m);

Console.WriteLine();
Console.WriteLine("Массив до изменения");
Print2DArray(arr);

OrderArray(arr);
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
Print2DArray(arr);

void OrderArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < arr.GetLength(1) - 1; z++)
            {
                if (arr[i, z] < arr[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
                {
                    int temp = 0;
                    temp = arr[i, z];
                    arr[i, z] = arr[i, z + 1];
                    arr[i, z + 1] = temp;
                }
            }
        }
    }
}

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];

    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
