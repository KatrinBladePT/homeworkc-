// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



float[] arr = new float[6];

void FillArray(float[] array)
{
    Random random = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = (float)random.NextDouble() * 100;
    }
}

double FindDifference(float[] array)
{
    float max = float.MinValue;
    float min = float.MaxValue;
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }

        if(array[i] < min)
        {
            min = array[i];
        }
    }
    
    double diff = max - min;
    
    return diff;
}

FillArray(arr);

Console.WriteLine($"Numbers {arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}, {arr[5]}");
Console.WriteLine($"Difference between max and min = {FindDifference(arr)}");