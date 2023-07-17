/*
Задача 64: 
Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в 
промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Clear();
Console.Write("Введите число: ");
int value = int.Parse(Console.ReadLine() ?? "");
Console.Write($"{value} -> {GetNum(1, value)}");

string GetNum(int start, int end)
{
    if (start == end)
        return start.ToString();
    return GetNum(start + 1, value) + ", " + start;
}