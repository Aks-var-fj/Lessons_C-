// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
string printNumbers(int number)
{
    return number == 1 ? number.ToString() :
           number + ", " + printNumbers(number - 1);
}

Console.Write("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"N = {number} -> {printNumbers(number)}");
*/
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int sumElements (int number1, int number2)
{
    int res = 0;
        return number1 > number2 ? res :
               res = number1 + sumElements(number1 + 1, number2);
}

Console.Write("Input the number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(sumElements(number1, number2));
*/
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackerman(m - 1, 1);
    else return Ackerman(m - 1, Ackerman(m, n - 1));
}

Console.Write("Input the number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int Ack = Ackerman(number1, number2);

System.Console.WriteLine($"m = {number1}, n = {number2} -> A({number1},{number2}) = {Ack}");
*/



