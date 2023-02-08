// Задача 1.
// Напишите программу, которая получает на вход двузначное число и показывает 
// наибольшую цифру числа.

// int Digits(int number)
// {
//     int ed = number % 10;
//     int dec = number / 10;
//     if (ed > dec)
//         return ed;
//     else if (ed < dec)
//         return dec;
//     else
//         return ed;
// }
// Console.Write("Введите 2-значное число: ");
// int user_number = Convert.ToInt32(Console.ReadLine());
// int result;
// if (user_number > 9 && user_number < 100)
// {
//     result = Digits(user_number);
//     Console.WriteLine($"Наибольшее число: {result}");
// }
// else
//     Console.WriteLine("Ваше число не 2-значное");

// Задача 2
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа. (78 -> 8, 12-> 2, 85 -> 8)

// int DigitRandom()
// {
//     int randomNum = new Random().Next(10, 100);
//     Console.WriteLine($"Сгенерируемый номер: {randomNum}");
//     int ed = randomNum % 10;
//     int dec = randomNum / 10;
//     if (ed > dec)
//         return ed;
//     else return dec;
// }
// Console.WriteLine("Наибольшее число: " + DigitRandom());

// Задача 3
// Напишите программу, которая принимает на вход число и проверяет, кратно ли 
// оно одновременно a и b. a, b вводит пользователь

// void Devider(int numberToDevide, int dev1, int dev2)
// {
//     if (numberToDevide % dev1 == 0 && numberToDevide % dev2 == 0)
//         Console.WriteLine($"Ваше число {numberToDevide} кратно одновременно {dev1} и {dev2}");
//     else Console.WriteLine($"Ваше число {numberToDevide} не кратно одновременно {dev1} и {dev2}");
// }
// Console.Write("Введите число: ");
// int user_number = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите первый делитель: ");
// int user_dev1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второй делитель: ");
// int user_dev2 = Convert.ToInt32(Console.ReadLine());
// Devider(user_number, user_dev1, user_dev2);

// Задача 4
// Напишите программу, которая выводит случайное трёхзначное число и удаляет 
// вторую цифру этого числа(456 -> 46, 789 -> 79)

// int NumberRandom()
// {
//     int randomNum = new Random().Next(100, 1000);
//     Console.WriteLine($"Ваше число: {randomNum}");
//     int num1 = randomNum / 100;
//     int num2 = randomNum % 10;
//     int num3 = num1 * 10 + num2;
//     return num3;
// }
// Console.WriteLine($"Результат: " + NumberRandom());

// Задача 5.
// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

// void Square(int num1, int num2)
// {
//     if (num1 * num1 == num2 || num2 * num2 == num1)
//         Console.WriteLine($"Одно число является квадратом другого");
//     else Console.WriteLine($"Одно число не является квадратом другого");
// }
// Console.Write("Введите первое число: ");
// int user_num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int user_num2 = Convert.ToInt32(Console.ReadLine());
// Square(user_num1, user_num2);