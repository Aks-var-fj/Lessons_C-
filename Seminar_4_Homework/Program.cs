//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.WriteLine("Input the number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {a} в степени {b} равно - {Math.Pow(a, b)}");
*/
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int sum (int num)
{
    int sum = 0;
    while (num >= 10)
    {
        sum = (sum + num % 10);
        num /= 10;
    }
    sum = sum + num;
    return sum;
}
Console.WriteLine("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(number));
*/
//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
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



