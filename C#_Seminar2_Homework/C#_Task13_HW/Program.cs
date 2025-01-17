﻿/*
Задача 13: Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine();

int GetNumber() // Функция, принимающая число (в т.ч. отрицательное).
{
  Console.Write("Введите число: ");
  int number = Convert.ToInt32(Console.ReadLine());
  number = Math.Abs(number);
  return number;
}

int ShowThirdDigit(int a) // Функция, которая выводит третью цифру заданного числа или сообщает о её отсутствии.
{
  if (a >= 1000)
  {
    return (a - a / 1000 * 1000) / 100;
  }

  else if (a >= 100)
  {
    return a / 100;
  }

  else
  {
    return -1;
  }
}

int num = GetNumber();
int result = ShowThirdDigit(num);

if (result == -1)
{
  Console.WriteLine("-> Третьей цифры нет.");
}

else
{
  Console.WriteLine($"-> Третьей цифрой заданного числа является {result}.");
}