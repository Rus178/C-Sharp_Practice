// Задача 1
// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N.
/*
void ShowNumbers(int number)
{
    if (number > 1) ShowNumbers(number - 1);
    Console.Write(number + " ");
}
Console.Write("Введите целое натуральное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
ShowNumbers(userNumber);
*/

// Задача 2
// Напишите программу, которая будет принимать на вход число и возвращать сумму 
// его цифр.
/*
int Sum(int num)
{
    if (num < 0) num *= -1;
    if (num > 0) return Sum(num / 10) + num % 10;
    else return 0;
}
Console.Write("Введите целое натуральное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма всех чисел равна: {Sum(userNumber)}");
*/

// Задача 3
// Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N (N < M, N = M, M < N).
/*
void ShowNumbers(int n, int m)
{
    if (Math.Min(n, m) != Math.Max(n, m)) ShowNumbers(Math.Min(n, m), Math.Max(n, m) - 1);
    Console.Write(Math.Max(n, m) + " ");
}
Console.Write("Введите первое целое натуральное число: ");
int userN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое натуральное число: ");
int userM = Convert.ToInt32(Console.ReadLine());
ShowNumbers(userN, userM);
*/

// Задача 4
// Напишите программу, которая на вход принимает два числа A и B, и возводит
// число А в целую степень B с помощью рекурсии.
/*
double Pow(int a, int b)
{
    if (b > 0) return Pow(a, b - 1) * a;
    if (b < 0) return Pow(a, b + 1) / a;
    else return 1;
}
Console.Write("Введите первое целое натуральное число: ");
int userN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое натуральное число: ");
int userM = Convert.ToInt32(Console.ReadLine());
Console.Write($"{userN} в степени {userM} = {Pow(userN, userM)}");
*/
