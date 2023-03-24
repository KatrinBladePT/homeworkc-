// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// void Main(int args)
// {
        
//         int res = 0;
//         Sum = 0;
//         while (args > 0)
//         {
//             res+= args % 10;
//             args /= 10;
//             if(args > 0)
//             {
//            res += Sum(args);
//            return result;
//             }
//         }

// }       
// Console.Write("Введите число N: ");
// string number = Console.ReadLine();
// int numb = int.Parse(number);
// sum = Main(numb);
// Console.WriteLine(sum);



// string? input = Console.ReadLine()!;
// int []res = int.Parse(input);
//Console.WriteLine(Main(input));

int SumNum(string number)
{
    int sum = 0;
    for(int i=0;i<=number.Length;i++)
    {
        sum += number[i];
        return sum;
    }
    return sum;
}
Console.WriteLine("Введите число");
string number = (Console.ReadLine()!);
SumNum(number);
Console.WriteLine("SumNum: " + SumNum(number));

