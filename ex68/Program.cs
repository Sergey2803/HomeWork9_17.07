/*
Задача 68: 
Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных 
числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Clear();
Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine() ?? "");

/*int rekurs(int m, int n)
{
    if ((m == 0) && (n == 0))
        return 1;
    if ((m > 0) && (n == 0))
        return rekurs(m - 1, n) + 1;
    return rekurs(m, n - 1) * n;
}
*/
int rekurs(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return rekurs(m - 1, 1);
    else
      return rekurs(m - 1, rekurs(m, n - 1));
}

Console.WriteLine($"m = {m}, n = {n} -> {rekurs(m, n)}");