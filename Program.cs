// Console.WriteLine("Hello, World!");

// Console.Clear();

// Семинар 1

// 1 Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).

// Console.Write("Введите число: ");

// int number = Convert.ToInt32(Console.ReadLine());

// int scrt = number * number;
// // number *= number;
// int scrt1 = Convert.ToInt32(Math.Pow(number, 2));

// Console.WriteLine("число в квадрате: " + scrt1);

// 2 Напишите программу, которая принимает на вход трехзначное число и на входе показывает последнюю цифру этого числа.


// Console.Write("Введите трехзначное число: ");
// int num = Math.Abs((Convert.ToInt32(Console.ReadLine())));
// if (num > 99 && num <= 999)
// {
//     Console.Write("Последняя цифра: " + num % 10);
// }
// else
// {
//     Console.WriteLine("Введенное число не трехзначное");
// }

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a != b)
// {
//     if (a > b)
//     {
//         Console.WriteLine("Min: " + b);
//         Console.WriteLine("Max: " + a);
//     }
//     else
//     {
//         Console.WriteLine("Min: " + a);
//         Console.WriteLine("Max: " + b);
//     }
// }
// else
// {
//     Console.WriteLine("Введите, пожалуйста, разные числа");
// }

// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;

// if (b > max) max = b;
// if (c > max) max = c;

// Console.WriteLine("Max: " + max);

// //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a % 2 == 0)
// {
//     Console.WriteLine("Число четное");
// }
// else
// {
//     Console.WriteLine("Число нечетное");
// }

// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.Write("Введите число больше 1: ");
// int a = Convert.ToInt32(Console.ReadLine());

// int i = 2;

// if (a > 1)
// {
//     while (i < a)
//     {
//         Console.Write(i + " ");
//         i += 2;
//     }
// }
// else{
//     Console.WriteLine("Введенное число меньше или равно 1");
// }