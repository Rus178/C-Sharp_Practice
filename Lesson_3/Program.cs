// Задача 1
// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится 
// эта точка.
/*
void Squares(int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine("Данная точка находится в 1ом квадрате");
    else if (x < 0 && y > 0)
        Console.WriteLine("Данная точка находится в 2ом квадрате");
    else if (x < 0 && y < 0)
        Console.WriteLine("Данная точка находится в 3ем квадрате");
    else if (x > 0 && y < 0)
        Console.WriteLine("Данная точка находится в 4ом квадрате");
    else Console.WriteLine("Данная точка находится на линии координат");
}
Console.Write("Введите x координату: ");
int xCoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y координату: ");
int yCoord = Convert.ToInt32(Console.ReadLine());
Squares(xCoord, yCoord);
*/

// Задача 2
// Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y).
/*
void PossibleValue(int nQuater)
{
    if (nQuater == 1)
        Console.WriteLine("В 1 четверти значения x > 0, y > 0");
    else if (nQuater == 2)
        Console.WriteLine("Во 2 четверти значения x < 0, y > 0");
    else if (nQuater == 3)
        Console.WriteLine("В 3 четверти значения x < 0, y < 0");
    else Console.WriteLine("В 4 четверти значения x > 0, y < 0");
}
Console.Write("Введите номер четверти: ");
int quaterNumber = Convert.ToInt32(Console.ReadLine());
if (quaterNumber >= 1 && quaterNumber <= 4)
    PossibleValue(quaterNumber);
else Console.WriteLine("Вы ввели некорректное значение");
*/

// Задача 3
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
/*
double DistanceAB(int xa, int ya, int xb, int yb)
{
    int deltaX = xa - xb;
    int deltaY = ya - yb;
    double distAB = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    return distAB;
}
Console.Write("Введите X координату точки A: ");
int xAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату точки A: ");
int yAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите X координату точки B: ");
int xBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату точки B: ");
int yBcoord = Convert.ToInt32(Console.ReadLine());
double distanceAB = DistanceAB(xAcoord, yAcoord, xBcoord, yBcoord);
Console.WriteLine($"Дистанция между точкой A и точкой B = {distanceAB:f2}");
*/

// Задача 4
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N(5 -> 1, 4, 9, 16, 25)(2 -> 1,4)
/*
void Quards(int uN)
{
    int current = 1;
    while (current <= uN)
    {
        int res = current * current;
        Console.Write($"{res}, ");
        current++;
    }
    Console.WriteLine("\b\b.");
}
Console.Write("Введите целое положительное число: ");
int user_number = Convert.ToInt32(Console.ReadLine());
if (user_number >= 1)
{
    Console.Write($"{user_number} -> ");
    Quards(user_number);
}
else Console.WriteLine("Введено некорректное значение");
*/