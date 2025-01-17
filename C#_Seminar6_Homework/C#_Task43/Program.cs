﻿/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int GetArgumentFromUser(string message)
{
  int result;

  while (true)
  {
    Console.Write(message);

    if (int.TryParse(Console.ReadLine()!, out result))
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не число или некорректное число. Повторите ввод!\n");
    }
  }
  return result;
}

(double, double) IntersectionOfTwoLines(int b1, int k1, int b2, int k2)
{
  double x = (double)(b2 - b1) / (k1 - k2);
  double y = k1 * x + b1;

  return (x, y);
}

Console.WriteLine();
int b1 = GetArgumentFromUser("Для уравнения вида y = k1 * x + b1 введите целочисленную константу b1: ");
int k1 = GetArgumentFromUser("Для уравнения вида y = k1 * x + b1 введите целочисленную константу k1: ");

int b2 = GetArgumentFromUser("Для уравнения вида y = k2 * x + b2 введите целочисленную константу b2: ");
int k2 = GetArgumentFromUser("Для уравнения вида y = k2 * x + b2 введите целочисленную константу k2: ");

if (k1 == k2)
{
  Console.WriteLine($"\n-> Графики заданных функций не пересекаются (прямые параллельны).");
}
else
{
  (double x, double y) = IntersectionOfTwoLines(b1, k1, b2, k2);
  Console.WriteLine($"\n-> Для двух функций, заданных прямыми, точкой пересечения является ({x}; {y}).");
}


// The example displays the following output:

// Для уравнения вида y = k1 * x + b1 введите целочисленную константу b1: 2
// Для уравнения вида y = k1 * x + b1 введите целочисленную константу k1: 5
// Для уравнения вида y = k2 * x + b2 введите целочисленную константу b2: 4
// Для уравнения вида y = k2 * x + b2 введите целочисленную константу k2: 9

// -> Для двух функций, заданных прямыми, точкой пересечения является (-0,5; -0,5).


// Для уравнения вида y = k1 * x + b1 введите целочисленную константу b1: qwer
// Ввели не число или некорректное число. Повторите ввод!

// Для уравнения вида y = k1 * x + b1 введите целочисленную константу b1: 2.2
// Ввели не число или некорректное число. Повторите ввод!

// Для уравнения вида y = k1 * x + b1 введите целочисленную константу b1: 0
// Для уравнения вида y = k1 * x + b1 введите целочисленную константу k1: -2
// Для уравнения вида y = k2 * x + b2 введите целочисленную константу b2: 5
// Для уравнения вида y = k2 * x + b2 введите целочисленную константу k2: -2

// -> Графики заданных функций не пересекаются (прямые параллельны).