//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] create_random_real_numbers_2d_array()
{
    Console.Write("Input a quantity rows in array: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity columns in array: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = Math.Round((new Random().NextDouble() * 100), 1);
        }
    }
    return array;
}

void show_real_number_2d_array (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j]}  ");
            }
            System.Console.WriteLine();
        }
}

double[,] myArray = create_random_real_numbers_2d_array();
System.Console.WriteLine();
show_real_number_2d_array(myArray);
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] create_random_2d_small_array_with_random_rows_and_columns()
{
    int rows = new Random().Next(3,10);
    int columns = new Random().Next(3,10);
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j< columns; j++)
        {
            array[i,j] = new Random().Next(0,100);
        }
    }
    return array;
}

void show_2d_array (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

bool cheking_the_index (int[,] array, int row, int columns)
{
    if (row < array.GetLength(0) || columns < array.GetLength(1)) return true;
    else return false;
}

void show_the_number_in_2d_array_by_coordinates (int[,] array)
{
    System.Console.Write("Input a number row in the array: ");
    int row = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Input a number column in the array: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    if (cheking_the_index(array, row, columns))
    {
        System.Console.WriteLine();
        System.Console.WriteLine(array[row,columns]);
    }
    else System.Console.WriteLine($"The number with the index ({row},{columns}) is not in the array");
}

int[,] my_array = create_random_2d_small_array_with_random_rows_and_columns();
System.Console.WriteLine();
show_2d_array(my_array);
System.Console.WriteLine();
show_the_number_in_2d_array_by_coordinates(my_array);
*/
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] create_random_2d_small_array_with_random_rows_and_columns ()
{
    int rows = new Random().Next (3,6);
    int columns = new Random().Next(3,6);
    int[,] array = new int[rows, columns];
    
    for (int i = 0; i < rows; i++)
        for (int j = 1; j < columns; j++)
            array[i,j] = new Random().Next(0,10);  
    return array;
}

void show_2d_array (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]}  ");
        System.Console.WriteLine();
    }
}

void show_array_with_double (double[] array)
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"{array[i]}  ");
    System.Console.WriteLine();
}

double[] arithmetic_mean_in_columns (int[,] array)
{
    double [] modified_array = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            modified_array[j] += array[i,j];
        }
        modified_array[j] = Math.Round((modified_array[j] / array.GetLength(0)), 1);
    }
    return modified_array;
}

int[,] my_array = create_random_2d_small_array_with_random_rows_and_columns();
show_2d_array(my_array);
System.Console.WriteLine();
double[] modified_array = arithmetic_mean_in_columns(my_array);
show_array_with_double(modified_array);
*/



























