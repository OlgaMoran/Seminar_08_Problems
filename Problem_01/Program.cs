// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

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

int[,] SwapFirstLastRows(int[,] array)
{
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    int temp = 0;
    for (int j = 0; j < b; j++)
    {
        temp = array[0, j];
        temp = array[a - 1, j];
        array[a - 1, j] = array[0, j];
        array[0, j] = temp;
    }
    return array;
}

int[,] myArray = new int[5, 5];
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();
SwapFirstLastRows(myArray);
PrintArray(myArray);