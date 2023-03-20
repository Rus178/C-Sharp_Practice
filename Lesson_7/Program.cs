// Задача 1
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4
/*
int[,] Create2dArray()
{
    Console.Write("Введите количесвто строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количесвто столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    int[,] createdArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            createdArray[i, j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    return createdArray;
}
void Show2dArray(int[,] array)
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
int[,] newArray = Create2dArray();
Show2dArray(newArray);
*/

// Задача 2
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
// по формуле: Aₘₙ = m+n. Выведите полученный массив на экран. m = 3, n = 4.
/*
int[,] Create2dArray()
{
    Console.Write("Введите количесвто строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количесвто столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] createdArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            createdArray[i, j] = i + j;
        }
    }
    return createdArray;
}
void Show2dArray(int[,] array)
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
int[,] newArray = Create2dArray();
Show2dArray(newArray);
*/

// Задача 3
//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и 
//замените эти элементы на их квадраты.
/*
double[,] Create2dArray()
{
    Console.Write("Введите количесвто строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количесвто столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    double[,] createdArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            createdArray[i, j] = Math.Round((new Random().Next(minVal, maxVal)) + (new Random().NextDouble()), 2);
        }
    }
    return createdArray;
}
void Show2dArray(double[,] array)
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
double[,] Change2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 1 && j % 2 != 1)
                array[i, j] = Math.Round(Math.Pow(array[i, j], 2), 2);
        }
    }
    return array;
}
double[,] newArray = Create2dArray();
Show2dArray(newArray);
Console.WriteLine();
double[,] changeArray = Change2dArray(newArray);
Show2dArray(changeArray);
*/
