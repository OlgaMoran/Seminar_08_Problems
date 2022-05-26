// Задача ДЗ 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void MinSum(int[,] array)
{
    int minSum = 0;
    int row = 0;
    for (int j = 0; j < array.GetLength(1); j++) minSum = minSum + array[0, j];

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < array.GetLength(1); j++) rowSum = rowSum + array[i, j];
        if (rowSum < minSum)
        {
            minSum = rowSum;
            row = i;
        }
    }
    Console.WriteLine($"Minimal sum: {minSum}");
    Console.WriteLine($"Row: {row}");
}

int[,] arr = new int[3, 5];
FillArray(arr);
PrintArray(arr);
MinSum(arr);