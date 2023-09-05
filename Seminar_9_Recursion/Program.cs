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
/*
void ShowNaturalNumbers(int min, int max, int count=0)
{
if(min>count) count=min;
else count++;

Console.Write(count + " ");

if(count<max) ShowNaturalNumbers(min, max, count);
}
Console.Write("Input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max: ");
int max = Convert.ToInt32(Console.ReadLine());
ShowNaturalNumbers(min, max);
*/
// Эльвира: Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int sum_digits(int number)
{
    if(number == 0) return 0;
    else return number % 10 + sum_digits(number / 10);
}

Console.WriteLine(sum_digits(556));
*/
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
/*
int power_AB(int a, int b)
{
    if (b == 0) return 1;
    else return a * power_AB(a, b - 1);
}

Console.WriteLine(power_AB(5,3));
*/









