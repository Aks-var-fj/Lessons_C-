//ДОМАШНЕЕ ЗАДАНИЕ
//                                                                            Seminar 2

// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
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
        int cifra2 = VtorayaCifra(number);
        Console.WriteLine($"Second digit of {number} is {cifra2}");
    }
else 
    {
        Console.WriteLine("Input correct number on range from 100 to 999");
    }
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет).
/*
int ThirdDigit (int num)
    {
        while (num >= 1000)
        {
            num /= 10;
        }
        return num % 10;        
    }

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
Console.WriteLine($"В числе {number} третья цифра - {ThirdDigit(number)}");
else Console.WriteLine($"В числе {number} третьей цифры нет");
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool ProverkaDnya (int digit)
    {
        if (digit < 6 && digit >= 1) return false;
        return true;
    }

Console.Write("Введите день недели: ");
int digit = Convert.ToInt32(Console.ReadLine());
if ( digit < 1) Console.WriteLine("Ошиблись с цифрой. Введите цифру от 1 до 7");
else if ( digit > 7) Console.WriteLine("Ошиблись с цифрой. Введите цифру от 1 до 7");
else if (ProverkaDnya(digit)) Console.WriteLine ("Да");
else Console.WriteLine("Нет");
*/

//                                                                            Seminar 3




