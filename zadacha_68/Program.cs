/* 
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Clear();
Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"FunAkerman = {printAkerman(m, n)}");

int printAkerman(int m, int n)
{
    if (m == 0) 
    return n + 1;
    if (n == 0) 
    return printAkerman(m - 1, 1);
    return printAkerman(m - 1, printAkerman(m, n - 1));
}


