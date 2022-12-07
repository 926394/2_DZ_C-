// Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры

Console.Write("Здравствуйте! Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int num1 = 0;

if (num > 99 & num < 1000)
{
    num1 = num % 10;
    Console.WriteLine("Ответ: " + num1);
    
}

if (num < 100) 
{
    Console.WriteLine("Извините! Третьей цифры нет: " + num);
}
if(num > 999)
    {
        Console.WriteLine("Это уже перебор " + num);
    } 

