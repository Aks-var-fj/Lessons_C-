//Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
// void print_number (int num)
// {
//     int res = 0;
//     while (res < num)
//     {
//         res++;
//         System.Console.Write(res);
//     }
// }

// System.Console.WriteLine("Input the number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// print_number(num);

// string PrintNumer(int num, string res)
// {
// if (num == 1)
// {
// res = res + '1';
// return res;
// }
// else
// {
// res = res + num;
// return PrintNumer(num - 1, res);
// }
// }
// string result = " ";

// Console.Write("Input the number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// result = PrintNumer(number, result);
// Console.WriteLine(result);


string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}

Console.WriteLine(PrintNumbers(1,8));
*/
// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


















