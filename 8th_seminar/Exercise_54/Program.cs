// Задача 54. Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

using System;

class Program {
  static void Main(string[] args) {
    int[,] arr = new int[,] {{3, 1, 2}, {6, 4, 5}, {9, 7, 8}};

    Console.WriteLine("Исходный массив:");
    PrintArray(arr);

    SortRows(arr);

    Console.WriteLine("\nМассив после сортировки строк:");
    PrintArray(arr);
  }

  static void SortRows(int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
      for (int j = 0; j < arr.GetLength(1) - 1; j++) {
        for (int k = j + 1; k < arr.GetLength(1); k++) {
          if (arr[i,j] < arr[i,k]) {
            int temp = arr[i,j];
            arr[i,j] = arr[i,k];
            arr[i,k] = temp;
          }
        }
      }
    }
  }

  static void PrintArray(int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
      for (int j = 0; j < arr.GetLength(1); j++) {
        Console.Write(arr[i,j] + " ");
      }
      Console.WriteLine();
    }
  }
}