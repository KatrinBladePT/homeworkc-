// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] arr;
arr = new int[6]; 

void FillArray(int []array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);
};
int CheckEved(int[] array)
{
    int evedCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evedCount ++;
        }
    }
     return evedCount;
}
FillArray(arr);
CheckEved(arr);

Console.WriteLine($"Numbers {arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}, {arr[5]}");
Console.WriteLine($"Eved number {CheckEved(arr)}");