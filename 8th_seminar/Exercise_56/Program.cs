// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
using System;

int r = new Random().Next(1,10);

int c = new Random().Next(1,10);

int [,] matrix = new int [r,c];

void FillArray(int[,] arr)
{
    Random random = new Random();

    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            arr[i, j] = random.Next(1,100);
        }
    }
}

FillArray(matrix);

void PrintArray(int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
      for (int j = 0; j < arr.GetLength(1); j++) {
        Console.Write(arr[i,j] + " ");
      }
      Console.WriteLine();
    }
    }
PrintArray(matrix);

int minSum = int.MaxValue;
int minIndex = -1;

    for (int i = 0; i < 6; i++)
    {
        int rowSum = 0;

        for (int j = 0; j < 4; j++)
        {
            rowSum += matrix[i, j];
        }

        if (rowSum < minSum)
        {
            minSum = rowSum;
            minIndex = i;
        }
    }

Console.WriteLine($"Строка с наименьшей суммой элементов {minIndex}");

