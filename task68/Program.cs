using System;
using static System.Console;
Clear();

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = Ack(m, n);

Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Write(input);
  int output = int.Parse(ReadLine());
  return output;
}