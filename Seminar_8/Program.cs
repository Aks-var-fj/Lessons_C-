// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

void change_rows(int[,] array, int r1, int r2)
{
    if(r1 >= 0 && r1 < array.GetLength(0) && r2 >= 0 && r2 < array.GetLength(0) && r1 != r2)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[r1, j];
            array[r1, j] = array[r2, j];
            array[r2, j] = temp;
        }
    }
}

int[,] myArray = create_random_2d_array();
show_2d_array(myArray);

System.Console.Write("Input a number of the first row to change: ");
int row1 = Convert.ToInt32(Console.ReadLine()) - 1;

System.Console.Write("Input a number of the second row to change: ");
int row2 = Convert.ToInt32(Console.ReadLine()) - 1;

change_rows(myArray, row1, row2);
show_2d_array(myArray);
*/
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
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

void ChangeRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i + 1; j < array.GetLength(0); j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    }
}

int [,] myArray = create_random_2d_array();
show_2d_array(myArray);
ChangeRows(myArray);
System.Console.WriteLine();
show_2d_array(myArray);
*/
// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
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

int[,] delete_row_and_column_with_min_value (int[,] array)
{
    int row = 0;
    int columns = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ( array[i,j] < array[row,columns])
            {    
                row = i;
                columns = j;  
            }
        }
    }

    int [,] new_array = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < new_array.GetLength(0); i++)
    {
        for (int j = 0; j < new_array.GetLength(1); j++)
        {
            if (i < row && j < columns) new_array[i,j] = array[i, j];
            if (i < row && j >= columns) new_array[i, j] = array[i, j + 1];
            if (i >= row && j < columns) new_array[i, j] = array[i + 1, j]; 
            if (i >= row && j >= columns) new_array[i, j] = array[i + 1, j + 1];
        }
                
    }
    return new_array;
}

int[,] my_array = create_random_2d_array();
show_2d_array(my_array);
System.Console.WriteLine();
int[,] modified_array = delete_row_and_column_with_min_value(my_array);
show_2d_array(modified_array);
*/





