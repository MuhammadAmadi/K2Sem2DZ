// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(num);
if (str.Length >= 3) Console.WriteLine(str[2]);
else Console.WriteLine("нет третьей цифры");