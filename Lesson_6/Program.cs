// Задача 1
// Напишите программу, которая перевернет исходный массив
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
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write("\b]");
}
int[] ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
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
Console.Write(" -> ");
ShowArray(ReverseArray(newArray));
*/

// Задача 2
// Напишите программу, которая будет преобразовывать десятичное число в 
// двоичное (45 -> 101101; 3 -> 11).
/*
string BinarySystem(int num)
{
    string result = string.Empty;
    while (num != 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}
Console.Write("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
string binaryNum = BinarySystem(userNum);
Console.Write($"{userNum} -> {binaryNum}");
*/

// Не используя рекурсию выведите первые N чисел Фибоначчи. Первые два числа 
// Фибоначчи: a и b (F(i) = F(i - 1) + F(i - 2)) (4 5 9 14 23 (N = 5)).
/*
int[] Fib(int size, int firstVal, int secondVal)
{
    int[] array = new int[size];
    array[0] = firstVal;
    array[1] = secondVal;
    for (int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
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
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое значение: ");
int firstVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе значение: ");
int secondVal = Convert.ToInt32(Console.ReadLine());
int[] newArray = Fib(size, firstVal, secondVal);
ShowArray(newArray);
Console.Write($"(N = {size})");
*/

// Задача 4
// Напишите программу, которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины. Каждая сторона треугольника 
// меньше суммы двух других сторон.
/*
void Triangle(int side1, int side2, int side3)
{
    if (side1 < side2 + side3 && side2 < side3 + side1 && side3 < side1 + side2)
        Console.Write("Треуольник с такими сторонами существует");
    else Console.Write("Треуольник с такими сторонами не существует");
}
Console.Write("Введите длину первой стороны: ");
int side1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину второй стороны: ");
int side2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину третьей стороны: ");
int side3 = Convert.ToInt32(Console.ReadLine());
Triangle(side1, side2, side3);
*/
