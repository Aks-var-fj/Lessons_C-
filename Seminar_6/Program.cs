// void ShowNum (int[] nums)
// {
//     nums[0] += 10;
//     Console.WriteLine(nums[0]);
// }

// int[] numbers = {5, 7, 8};

// ShowNum(numbers);

// Console.WriteLine(numbers[0]);

// Task 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
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

// void ReverseArray(int[] array)
// {
//     for(int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }

void ReverseArray2(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

Console.Write("Input a length of an array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m, a, b);
WriteArray(myArray);
ReverseArray2(myArray);
WriteArray(myArray);
*/

// Task 2. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
bool Proverka (int a, int b, int c)
{
    if (a < (b + c) && b < (a + c) && c < (a + b)) return true;
    else return false;
}

Console.Write("Input num 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num 3: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Proverka(a, b, c));
*/

// Task 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
/*
int[] Fibonachi(int length)
{
    int[] array = new int[length];
    array[0] = 0;
    array[1] = 1;
    for ( int i = 2; i < length; i++)
        {
            array[i] = array[i-2] + array[i-1];
        }
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Input length: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] myArray = Fibonachi(a);
WriteArray(myArray);
*/

// Task 4. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
/*
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

int[] copy_array(int[] array)
{
    int[] array_copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        array_copy[i] = array[i];
    return array_copy;
}

Console.Write("Input a lenght of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);
WriteArray(myArray);
int[] copy_my_array = copy_array(myArray);
WriteArray(copy_my_array);
*/
           