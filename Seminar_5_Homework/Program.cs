// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] create_random_array (int size) // можно ли вместо аргументов оставить поле пустым а в цикле сделать рандомнекст?
{
    int[] array = new int[size]; // можно ли сюда записать рандомнекст?
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100,1000);
    return array;
}
void write_array (int[] array) // Данный метод используется только для вывода сгенерированного массива на экран
{
    for (int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine(); // Данная команда используется для переноса курсора на следующую строку для удобства визуализации
}
int number_of_even_digits (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count ++;
    return count;
}

Console.Write("Enter a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] my_array = create_random_array(length);
write_array(my_array);
Console.WriteLine(number_of_even_digits(my_array));
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] create_random_array (int size, int min_value, int max_value)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min_value,max_value + 1);
    return array;
}
void write_array (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int sum_of_negatives (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}
Console.Write("Enter a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a left border of array: ");
int min_value = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a right border of array: ");
int max_value = Convert.ToInt32(Console.ReadLine());

int [] my_array = create_random_array(length, min_value, max_value);
write_array(my_array);
Console.Write(sum_of_negatives(my_array));
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и
//минимальным элементов массива.
/*
double[] create_random_array (int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter number in array with index {i}: ");
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
    return array;
}
void write_array (double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
double difference_between_max_min (double[] array)
{
    double result = 0;
    double min = array[array.Length - 2];
    double max = array[array.Length - 1];
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
            if (array[i] < min)
                min = array[i];
            result = max - min;
        }
    return result;
}

Console.Write("Enter a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());

double[] my_array = create_random_array(length);
write_array(my_array);
Console.WriteLine(difference_between_max_min(my_array));
*/













