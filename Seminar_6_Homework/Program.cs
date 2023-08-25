//HomeWork
//Написать программу, преобразующую число из десятеричной системы счисления в двоичную.
/*
int determining_the_length_of_an_array (int number)
{
    int count = 0;
    int num1 = number;
    while (num1 >= 1)
    {
        num1 /= 2;
        count++;
    }
    return count;
}

int[] converting_to_binary_code(int size, int number)
{
    int[] binary_code = new int[size];
    for (int i = 0; i < size; i++)
    {
        if (number %2 != 0) binary_code[i] = 1;
        else binary_code[i] = 0;
        number = number / 2;
    }
    return binary_code;
}

void ReverseArray2(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input number for converting to binary code: ");
int num = Convert.ToInt32(Console.ReadLine());
int size = determining_the_length_of_an_array(num);
Console.WriteLine(size);
int[] myArray = converting_to_binary_code(size, num);
ReverseArray2(myArray);
WriteArray(myArray);
*/

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int digits_greater_than_zero(int quantity)
{   int count = 0;
    for (int i = 1; i <= quantity; i++)
        {
            Console.WriteLine("Input number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0) count++;
        }
    return count;
}

Console.WriteLine("Input quantity digits: ");
int quantity = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(digits_greater_than_zero(quantity));
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
bool validate_lines(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine ("Straight lines match");
            return false;
        }
        else 
        {
            Console.WriteLine ("Straight lines are parallel");
            return false;
        }
    }
    return true;
}

double[] find_coordinates (double b1, double k1, double b2, double k2)
{
    double[] coordinates = new double[2];
    coordinates[0] = (b2 - b1) / (k1 - k2);
    coordinates[1] = k2 * coordinates[0] + b2;
    return coordinates;
}

void write_coordinates (double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "   ");
    Console.WriteLine();
}

Console.WriteLine("Input meaning b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input meaning k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input meaning b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input meaning k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if(validate_lines(b1, k1, b2, k2))
{
    double[] coordinates = find_coordinates(b1, k1, b2, k2);
    Console.WriteLine($"Точка пересечения прямых с уравнениями y={k1}*x+{b1} и y={k2}*x+{b2} имеет координаты ");
    write_coordinates(coordinates);
}
*/



