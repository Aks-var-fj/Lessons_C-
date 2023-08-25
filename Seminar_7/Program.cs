//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
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
            Console.Write($"{array[i, j]} ");
        }    
        Console.WriteLine();
    }

}

int[,] my_array = create_random_2d_array();
show_2d_array(my_array);
*/

//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
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
            array[i, j] = i + j;
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

int[,] my_array = create_random_2d_array();
show_2d_array(my_array);
*/

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
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

void change_even_elements_by_squares(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i, j] *= array[i, j];
        }
    }
}

int[,] my_array = create_random_2d_array();
show_2d_array(my_array);
change_even_elements_by_squares(my_array);
Console.WriteLine();
show_2d_array(my_array);
*/

//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
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

int the_sum_of_the_elements_of_the_main_diagonal(int[,] array)
{
int sum =0;
for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    {
        sum = sum + array[i, i];
        if (i < array.GetLength(0) - 1 && i < array.GetLength(1) - 1) System.Console.Write($"{array[i, i]} + ");
        else Console.Write($"{array[i, i]} ");
    }
return sum;

}

int[,] my_array = create_random_2d_array();
show_2d_array(my_array);
System.Console.WriteLine();
System.Console.Write($"= {the_sum_of_the_elements_of_the_main_diagonal(my_array)}");
*/

//Задайте двумерный массив. Отсортируйте содержимое каждой строки по убыванию.
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


