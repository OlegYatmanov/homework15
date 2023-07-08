using System;
using static System.Console;
Clear();

int m = InputNumber("Введите M:");
int n = InputNumber("Введите N:");
WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");


int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}

int InputNumber(string message)
{
    WriteLine(message);
    return int.Parse(ReadLine());
}