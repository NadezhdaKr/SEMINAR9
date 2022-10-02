// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
int n = InputInt("Введите число: ");
int m = 1;
if (n < 1)
{
    Console.WriteLine();
}
Console.WriteLine(NaturalNumber(n, m));

int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int M = InputInt("Введите M: ");
int N = InputInt("Введите N: ");
Console.WriteLine($"Сумма элементов от {M} до {N} = {CountNaturalSum(M, N)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int M, int N)
{
    if (M == N)
        return N;
    return N + CountNaturalSum(M, N - 1);
}