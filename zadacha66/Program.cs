/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();
Console.WriteLine("Введите число M(начало): ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N(конец): ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Cумма = {PrintSumNumbers(m, n)}");

int PrintSumNumbers(int m, int n)
{
    if (m == n) 
    return m;
    return (m + PrintSumNumbers(m + 1, n));
}


