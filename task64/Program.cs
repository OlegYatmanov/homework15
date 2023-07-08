using System;
using static System.Console;
Clear();

Write("Введи M: ");
int M = int.Parse(ReadLine());
Write("Введи N: ");
int N = int.Parse(ReadLine());
WriteLine($"N={M}, M={N}");
if (M>N)
for (int i = N; i <= M; i++)
    Write($" {i}");
else
    for (int i = M; i <= N; i++)
        Write($" {i}");