// Задача 15: Напишите программу, которая принимает на вход
// цифру, обозначающую день недели, и проверяет, является ли
// этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine()!);

if (num == 1 & num == 2 || num == 3 || num == 4 || num == 5)
{
    Console.WriteLine("Ответ: будничный день");
}

if (num == 6 || num == 7)
{
    Console.WriteLine("Ответ: выходной день");
}
if (num == 0 || num > 7)
{
    Console.WriteLine("Такого дня нет!");
}