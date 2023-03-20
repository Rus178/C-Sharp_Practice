// Задача 1
// Задайте двумерный массив. Напишите программу, которая поменяет местами две 
// любые строки массива.
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
int[,] ChangeArray(int[,] arrayToChange)
{
    Console.Write("Введите номер первой строки для замены: ");
    int row1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер второй строки для замены: ");
    int row2 = Convert.ToInt32(Console.ReadLine());
    if (row1 >= 0 && row1 < arrayToChange.GetLength(0) && row2 >= 0 && row2 < arrayToChange.GetLength(0))
    {
        for (int j = 0; j < arrayToChange.GetLength(1); j++)
        {
            int temp = arrayToChange[row1, j];
            arrayToChange[row1, j] = arrayToChange[row2, j];
            arrayToChange[row2, j] = temp;
        }
    }
    else Console.WriteLine("Введены некорректные значения");
    return arrayToChange;
}
int[,] newArray = Create2dArray();
Show2dArray(newArray);
int[,] changeArray = ChangeArray(newArray);
Show2dArray(changeArray);
*/

// Задача 2
// Задайте двумерный массив. Напишите программу, которая заменяет строки на 
// столбцы. В случае, если это невозможно, программа должна вывести сообщение  
// для пользователя.
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
    Console.WriteLine();
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
    Console.WriteLine();
}
int[,] ChangeArray(int[,] arrayToChange)
{
    for (int i = 0; i < arrayToChange.GetLength(0); i++)
        for (int j = i; j < arrayToChange.GetLength(1); j++)
        {
            int temp = arrayToChange[i, j];
            arrayToChange[i, j] = arrayToChange[j, i];
            arrayToChange[j, i] = temp;
        }
    return arrayToChange;
}
int[,] newArray = Create2dArray();
if (newArray.GetLength(0) == newArray.GetLength(1))
{
    Show2dArray(newArray);
    int[,] changeArray = ChangeArray(newArray);
    Show2dArray(changeArray);
}
else Console.WriteLine("Количество строк и столбцов должны быть равны");
*/

// Задача 3
// Задайте двумерный массив из целых чисел. Напишите программу, которая обнулит 
// строку и столбец, на пересечении которых расположен первый наименьший элемент 
// массива.
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
    Console.WriteLine();
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
    Console.WriteLine();
}
int[] FindMin(int[,] array)
{
    int[] minIndex = new int[2];
    int iMin = 0;
    int jMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[iMin, jMin])
            {
                iMin = i;
                jMin = j;
            }
        }
    minIndex[0] = iMin;
    minIndex[1] = jMin;
    return minIndex;
}
int[,] ChangeArray(int[,] array, int[] index)
{
    for (int i = 0; i < array.GetLength(0); i++)
        array[i, index[1]] = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        array[index[0], j] = 0;
    return array;
}
int[,] newArray = Create2dArray();
Show2dArray(newArray);
int[] findMinIndex = FindMin(newArray);
Show2dArray(ChangeArray(newArray, findMinIndex));
*/
