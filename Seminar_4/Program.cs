﻿//Task 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int sum (int a)
{
    int result = 0;
    for(int i = 1; i <= a; i++)
        result += i;
    return result;
}
Console.WriteLine("Input the number: ");
int nunumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(nunumber));
*/
//Task 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int CountNumbers(int n)
{
    int count = 1;
    for(; n >= 10; count++)
        n = n/10;
    return count;
}
Console.WriteLine("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CountNumbers(number));
*/
//Task 3. Напишите программу, которая принимает на вход число N и выдаёт произведение нечетных чисел от 1 до N.
/*
int proizvedenie (int a)
{
    int result = 1;
    for(int i = 1; i <= a; i += 2)
        result *= i;
    return result;
}

Console.WriteLine("Input the number: ");
int nunumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(proizvedenie(nunumber));
*/
//Task 4. Программа с рандомным массивом
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
WriteArray(myArray);
*/




