/*
int intNumber = 25; //тип данных целочисленные
double doubleNumber = 12.12; //тип данных десятичные
string text = "some text";
bool logicVar = true;
*/

// int num1 = 5;
// int num2 = 10;
//Console.WriteLine ($"My number are {num1} and {num1} and it is good!");
//Console.WriteLine ("My number are " + num1 + " and " + num1 + " and it is good!");


// Console.Write ("input a number ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("My number are " + num1 + " and " + num1 + " and it is good!");
// Console.WriteLine ($"My number are {num1} and {num1} and it is good!");


//Task 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;
if(num1 == quad2)
{ // если команда одна в этих скобках то можно не ставить их
//if(num1 == quad2) Console.WriteLine("Yes!")
//else Console.WriteLine("No!");
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}
*/

//Task 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Input a number ");
int num = Convert.ToInt32(Console.ReadLine());
int current = -num;
while(current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/

//ДОМАШНЕЕ ЗАДАНИЕ.

//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите первое число - ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число - ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write(num1);
}
else {Console.Write(num2);}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите первое число - ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число - ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число - ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (max > num2)
{
   if (max > num3)
   {
    Console.WriteLine(max);
   }
}
max = num2;
if (max > num3)
{
    Console.WriteLine(max);
}
else {Console.WriteLine(num3);}
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


/*4 -> да
-3 -> нет
7 -> нет

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/