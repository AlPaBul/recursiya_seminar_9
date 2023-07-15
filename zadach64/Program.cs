/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Clear();

Console.WriteLine("введите любое число N: ");
int numberN = int.Parse(Console.ReadLine());

Console.WriteLine(PrintNumber(numberN));

string PrintNumber (int start)
{
    int end = 1;
    if (end == start) 
    return end.ToString();
    return (start + " " + PrintNumber(start - 1));
}
