/*
Задача 66: 
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();
Console.Write("Введите первое число: ");
int M = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число: ");
int N = int.Parse(Console.ReadLine() ?? "");
Console.Write($"M = {M}, N = {N} -> {GetSum(M, N + 1)}");

int GetSum(int M, int N)
{
    if (M >= N)
        return 0;
    return M + GetSum(M + 1, N);
}