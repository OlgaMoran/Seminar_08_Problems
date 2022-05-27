// Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

void SwapRowsAndColumns(int[,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int temp = 0;
    if (x == y)
    {
        for (int i = 0; i < x - 1; i++)
        {
            for (int j = i + 1; j < y; j++)
            {
                temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
    }
    else Console.WriteLine($"Can't do the swap. Number of rows should be equal to number of columns!");
}

int[,] arr = new int[4, 4];
int x = arr.GetLength(0);
int y = arr.GetLength(1);
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
SwapRowsAndColumns(arr);
if (x == y) PrintArray(arr);
