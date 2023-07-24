﻿// Seminar 2. Методы и функции

// Theory
/*
13254 / 10 = 1325 целочисленное деление
13254 / 100 = 132
13254 / 1000 = 13

13254 % 10 = 4 поиск остатка от деления
13254 % 100 = 54
13254 % 1000 = 254

24365 -> 43 делим на сто, потом извлекаем остаток от деления на сто
*/

// Практические задания на лекции
 
// Task 1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
//351 -> 3 1 -> 31
int CutNumber(int num)
{
    int hundreds = num / 100;
    int units = num % 10;
    int res = hundreds * 10 + units; // можно прописать так  (return hundreds * 10 + units;)
    return res;
}
int randNumber = new Random().Next(100,1000);
int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/

// Task 2. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.
/*
bool IsDividible(int num, int div1, int div2)
{
    // if (num % div1 == 0 && num % div2 == 0) // && логическое "И", || логичесчкое "или"
    //     return true;
    // else 
    //     return false;
    return num % div1 == 0 && num % div2 == 0; //сокращенное написание предыдущих 4 строк
}
Console.Write("Input a number for checking: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("input a first divider: ");
int divider1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a first divider: ");
int divider2 = Convert.ToInt32(Console.ReadLine());

bool res = IsDividible(number, divider1, divider2);

if (res) Console.Write("Yes");
else Console.Write("No");
*/

// Task 3. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int maxDigit(int num)
{
    int desatki = num / 10;
    int units = num % 10;
    if (desatki > units) return desatki;
    else return units;
}
int randNumber = new Random().Next(10,100);
int res = maxDigit (randNumber);
Console.WriteLine(randNumber);
Console.WriteLine(res);
*/

// Task 4. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
bool KvadratChisla(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}
Console.Write("Input a number 1 for checking: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 2 for checking: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool res = KvadratChisla(num1, num2);

if (res) Console.Write("Yes");
else Console.Write("No");
*/

//ДОМАШНЕЕ ЗАДАНИЕ

// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

int VtorayaCifra(int num)
{
    int num1 = num / 10;
    int res = num1 % 10;
    return res;
}

Console.Write("Input number from 100 to 999: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number < 1000)
{
    int cifra2 = VtorayaCifra (number);
    Console.WriteLine($"Second digit of {number} is {cifra2}");
}
else 
{
    Console.WriteLine("Do you now range number from 100 to 999??? otvet y or n");
    string? otvet = Console.ReadLine();
    if (otvet == "y" || otvet =="n")
    {
        if (otvet == "y")
        {
            Console.WriteLine("Nu togda vvedi ego, ty ge ne tupoi");
        }
        if (otvet == "n")
        {
            Console.WriteLine("Pozdravlay ty tupoi");
        }
    }
    else
    {
        Console.WriteLine("Napishi otvet normalno!!!");
        string? b = Console.ReadLine();
        do 
        {
            Console.WriteLine("Napishi otvet normalno!!!!");
            string? otv = Console.ReadLine();
        }
        while (b != "y" || b !="n");
        if (otvet == "y")
            {
                Console.WriteLine("Nu togda vvedi ego, ty ge ne tupoi");
            }
            if (otvet == "n")
            {
                Console.WriteLine("Pozdravlay ty tupoi");
            }
        
    }
    
}