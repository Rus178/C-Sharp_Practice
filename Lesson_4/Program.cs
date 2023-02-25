// Задача 1
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел 
// от 1 до А.
/*
void Findsumm(int num_a)
{
    int sum = 0;
    for (int current = 0; current <= num_a; current++)
    {
        sum += current;
    }
    Console.WriteLine($"Сумма числе от 1 до {num_a} = {sum}");
}
Console.Write("Введите целое положительное число: ");
int user_num = Convert.ToInt32(Console.ReadLine());
if (user_num > 0)
    Findsumm(user_num);
else Console.Write("Введено некорректное значение");
*/

// Задача 2
// Напишите программу, которая принимает на вход число и выдаёт количество цифр 
// в числе (456 -> 3, 78 -> 2, 89126 -> 5).
/*
void CountOfDigits(int number)
{
    int countOfDigits = 1;
    while (Math.Abs(number) > 9)
    {
        number /= 10;
        countOfDigits++;
    }
    Console.Write($"{countOfDigits}");
}
Console.Write("Введите число: ");
int user_number = Convert.ToInt32(Console.ReadLine());
Console.Write($"В числе {user_number} колличеств цифр -> ");
CountOfDigits(user_number);
*/

// Задача 3
// Напишите программу, которая принимает на вход число N и выдаёт произведение 
// чисел от 1 до N (4 -> 24, 5 -> 120).
/*
void Findmulti(int num_a)
{
    int multi = 1;
    for (int current = 1; current <= num_a; current++)
    {
        multi *= current;
    }
    Console.WriteLine($"{num_a} -> {multi}");
}
Console.Write("Введите целое положительное число: ");
int user_num = Convert.ToInt32(Console.ReadLine());
if (user_num > 0)
    Findmulti(user_num);
else Console.Write("Введено некорректное значение");
*/

// Задача 4
// Напишите программу, которая выводит массив из 8 элементов, заполненный 
// нулями и единицами в случайном порядке ([1,0,1,1,0,1,0,0]).
/*
int[] CreateNewArray(int size_array)
{
    int[] random01array = new int[size_array];
    for (int i = 0; i < size_array; i++)
        random01array[i] = new Random().Next(0, 2);
    return random01array;
}
void ShowCreateArray(int[] array01)
{
    for (int i = 0; i < array01.Length; i++)
        Console.Write($"{array01[i]} ");
}
int[] arrayNew = CreateNewArray(8);
ShowCreateArray(arrayNew);
*/
