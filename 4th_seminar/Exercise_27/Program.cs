// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int SumNum(string number)
{
    int sum = 0;
    for(int i=0;i<number.Length;i++)
    {
        sum += Int32.Parse(number[i].ToString()); // добавлена конвертация символа в число
    }
    return sum;
}

Console.WriteLine("Введите число");
string number = Console.ReadLine();
Console.WriteLine("SumNum: " + SumNum(number));












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

// int SumNum([] number)
// {
//     int sum = 0;
//     for(int i=0;i<number.Length;i++)
//     {
//         sum += number[i];
//     }
//     return sum;
// }
// Console.WriteLine("Введите число");
// int []number = new []{int.Parse(Console.ReadLine()!)};
// SumNum(number);
// Console.WriteLine("SumNum: " + SumNum(number));

