// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.


int[,] array = new int[,] 
{ 
    { 1, 2, 3 }, 
    { 4, 5, 6 }, 
    { 7, 8, 9 } 
};

double[] columnAverage = new double[array.GetLength(1)];

for (int j = 0; j < array.GetLength(1); j++)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    columnAverage[j] = (double)sum / array.GetLength(0);
}

// Вывод результатов
for (int j = 0; j < array.GetLength(1); j++)
{
    Console.WriteLine("Среднее арифметическое столбца {0}: {1}", j + 1, columnAverage[j]);
}