// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] create_random_2d_array()
{
    Console.Write("Input a quantity rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
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
            Console.Write(array[i, j] + " ");
        }    
        Console.WriteLine();
    }

}

void sorting_items_in_descending_order (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            } 
        }  
    }
}

int[,] my_array = create_random_2d_array();
show_2d_array(my_array);
System.Console.WriteLine();
sorting_items_in_descending_order(my_array);
show_2d_array(my_array);
*/
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] create_rectangular_random_2d_small_array_with_random_rows_and_columns ()
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

void the_row_with_the_smallest_sum_of_elements (int[,] array)
{
    int [] array_rows = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array_rows[i] += array[i,j];
        }
    }
    int min = array_rows[0];
    int row_with_min_sum = array_rows[0];
    for (int i = 0; i < array_rows.Length; i++)
        {
            if (array_rows[i] < min)
            {
                min = array_rows[i];
                row_with_min_sum = i;
            }
        }
    System.Console.WriteLine($"{row_with_min_sum} строка");
}

int[,] my_array = create_rectangular_random_2d_small_array_with_random_rows_and_columns();
show_2d_array(my_array);
System.Console.WriteLine();
the_row_with_the_smallest_sum_of_elements(my_array);
*/
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] create_random_2d_array()
{
    Console.Write("Input a quantity rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0,10);
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
            Console.Write(array[i, j] + " ");
        }    
        Console.WriteLine();
    }

}

void multiplying_arrays (int[,] array1, int[,] array2)
{
    int[,] array = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array2.GetLength(0); k++)
                {
                    array[i,j] += (array1[i,k] * array2[k,j]);
                }
            System.Console.Write($"{array[i,j]} ");
            }
            System.Console.WriteLine();
        }
    }
    else System.Console.WriteLine("Матрицы не могут быть пермножены!");
}

System.Console.WriteLine("Set the dimensions of the first array: ");
int[,] my_array1 = create_random_2d_array();
show_2d_array(my_array1);
System.Console.WriteLine("Set the dimensions of the second array");
int[,] my_array2 = create_random_2d_array();
show_2d_array(my_array2);
System.Console.WriteLine();
multiplying_arrays(my_array1, my_array2);
*/
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] create_random_3d_array_from_non_repeating_two_digits_numbers ()
{
    int rows = new Random().Next(2,4);
    int columns = new Random().Next(2,4);
    int depth = new Random().Next(2,4);
    int[,,] array = new int[rows, columns, depth];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < depth; k++)
            {
                int temp = new Random().Next(10,100);
                while (number_in_array(array, temp))
                {
                    temp =  new Random().Next(10,100);
                }
                array[i,j,k] = temp;
            }
    return array;
}

bool number_in_array(int [,,] array, int num) 
 { 
    for (int i = 0; i < array.GetLength(0); i++) 
         for (int j = 0; j < array.GetLength(1); j++) 
             for (int k = 0; k < array.GetLength(2); k++) 
                 if(num == array[i, j, k]) 
                     return true; 
     return false; 
 }

void show_3d_array (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
        System.Console.WriteLine();
        }
    System.Console.WriteLine();
    }
        
}

int[,,] my_array = create_random_3d_array_from_non_repeating_two_digits_numbers();
show_3d_array(my_array);
*/
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] create_random_2d_small_array_with_random_rows_and_columns()
{
    int rows = 6;
    int[,] array = new int[rows, rows];
    int i = 0, j = 0;
    int value = 1;
    for (int itterations = 0; itterations < rows * rows; itterations++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < rows - 1);
        for (k = 0; k < rows - 1; k++) array[i++, j] = value++;
        for (k = 0; k < rows - 1; k++) array[i, j--] = value++;
        for (k = 0; k < rows - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        rows = rows < 2 ? 0 : rows - 2;
    }
    return array;
}

void show_2d_fill_array (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < 10) System.Console.Write($"0{array[i,j]} ");
            else System.Console.Write(array[i, j] + " ");
        }    
        Console.WriteLine();
    }

}

int[,] my_array = create_random_2d_small_array_with_random_rows_and_columns();
show_2d_fill_array(my_array);












