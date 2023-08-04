                                                                //ДОМАШНЕЕ ЗАДАНИЕ

//                                                                     Seminar 3

// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
int Palindrom (int num)
{
    int reverse_number = 0; //вводим интовое перевернутое число (выделяем память под него)
    while (num >= 10) //цикл для переворачивания числа
    {
        reverse_number = (reverse_number + num % 10) * 10; //формируем перевертыша
        num /= 10; //убираем крайний разряд и далее по циклу
    }
    reverse_number = reverse_number + num; //последний разряд не попадает в цикл, поэтому накидываем его вне цикла
    Console.WriteLine(reverse_number);
    return reverse_number;
}
Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int res = Palindrom(number);

if (res == number) Console.Write("Yes");
else Console.Write("No");
*/
// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
    {return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));}

Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Distance (x1, y1, z1, x2, y2, z2));
*/
// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Vozvedenie_V_Kub(int number)
    {
        if (number <= 0) Console.WriteLine("Uncorrectected number");
        else
            {
                int count = 1;
                while (count <= number)
                {
                    Console.WriteLine($"{count} - {Math.Pow(count,3)}");
                    count++;
                }
            }
    }
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Vozvedenie_V_Kub(num);
*/


