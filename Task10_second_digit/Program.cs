// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого
// числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Write("Здравствуйте! Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
int num1 = 0;
int num2 = 0;

if (num < 1000 & num > 99)
{
    num1 = num / 10;
    num2 = num1 % 10;
    Console.WriteLine("Ответ: " + num2);
}
else
{
    Console.WriteLine("Извините! Это не то число: " + num);
}
