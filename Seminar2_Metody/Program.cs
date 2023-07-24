// Seminar 2. Методы и функции

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

// Task 2. 

