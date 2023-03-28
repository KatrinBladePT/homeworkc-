// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] arr;
arr = new int[6]; 

void FillArray(int []array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0,100);
};
int SumUneven(int[] array)
{
    int unevensum = 0;
    for(int i = 1; i < array.Length; i= i +2)
    unevensum = unevensum + array[i];
    return unevensum; 
}
FillArray(arr);
SumUneven(arr);

Console.WriteLine($"Numbers {arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}, {arr[5]}");
Console.WriteLine($"Sum Uneven numbers: {SumUneven(arr)}");