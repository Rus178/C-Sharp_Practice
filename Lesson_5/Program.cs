// Задача 1
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка 
// [-9, 9].Найдите сумму отрицательных элементов массива. Например, в массиве 
// [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма отрицательных равна -20.
/*
int[] CreateNewArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int FindSumNeg(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            sum += array[i];
    }
    return sum;
}
int size = 12;
int minVal = -9;
int maxVal = 9;
int[] newArray = CreateNewArray(size, minVal, maxVal);
ShowArray(newArray);
Console.Write($"сумма отрицательных чисел равна {FindSumNeg(newArray)}");
*/

// Задача 2
// Напишите программу замены элементов массива: положительные элементы замените 
// на соответствующие отрицательные и наоборот([-4, -8, 8, 2] -> [4, 8, -8, -2])
/*
int[] CreateNewArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int[] RewriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int maxVal = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateNewArray(size, minVal, maxVal);
ShowArray(newArray);
RewriteArray(newArray);
ShowArray(newArray);
*/

// Задача 3
// Задайте массив. Напишите программу, которая определяет, присутствует ли 
// заданное число в массиве (4; массив [6, 7, 19, 345, 3] -> нет).
/*
int[] CreateNewArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
bool FindNumber(int[] array, int findNumber)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == findNumber)
            return true;
    }
    return false;
}
Console.Write("Введите число: ");
int findNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int maxVal = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateNewArray(size, minVal, maxVal);
Console.Write($"{findNumber}; массив ");
ShowArray(newArray);
bool result = FindNumber(newArray, findNumber);
if (result == true)
    Console.Write(" -> да");
else Console.Write(" -> нет");
*/

// Задача 4
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
// последний элемент, второй и предпоследний и т.д. Результат запишите в новом 
// массиве ([1 2 3 4 5] -> 5 8 3; [6 7 3 6] -> 36 21).
/*
int[] CreateNewArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int NewArraySize(int start_size)
{
    int end_size = 0;
    if (start_size % 2 == 0)
        end_size = start_size / 2;
    else end_size = start_size / 2 + 1;
    return end_size;
}
int[] Multi(int[] massive)
{
    int result_size = NewArraySize(massive.Length);
    int[] resultArray = new int[result_size];
    for (int i = 0; i < massive.Length / 2 + 1; i++)
    {
        if (i == massive.Length - 1 - i)
            resultArray[i] = massive[i];
        else resultArray[i] = massive[i] * massive[massive.Length - 1 - i];
    }
    return resultArray;
}
int[] firstArray = CreateNewArray(5, 0, 9);
ShowArray(firstArray);
int[] secondArray = Multi(firstArray);
Console.Write("-> ");
ShowArray(secondArray);
*/
