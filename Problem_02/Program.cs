// Задача ДЗ 1. 
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

void FillArray(int[,] matrix)
{
    int x = matrix.GetLength(0);
    int y = matrix.GetLength(1);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    int x = matrix.GetLength(0);
    int y = matrix.GetLength(1);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] RowsSortedDescending(int[,] Array)
{
    int a = Array.GetLength(0);
    int b = Array.GetLength(1);
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int m = 0; m < a; m++)
            {
                for (int n = 0; n < b - 1; n++)
                {
                    if (Array[m, n] < Array[m, n + 1])
                    {
                        int temp = Array[m, n];
                        Array[m, n] = Array[m, n + 1];
                        Array[m, n + 1] = temp;
                    }
                }
            }
        }
    }
    return Array;
}

int[,] arr = new int[5, 5];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
PrintArray(RowsSortedDescending(arr));
