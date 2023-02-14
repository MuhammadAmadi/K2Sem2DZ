// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(num);
if (str.Length == 3) Console.WriteLine(str[1]);
else Console.WriteLine("Вы ввели не трехзначную цифру");