﻿/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int GetNaturalNumber(string message)
{
  int result = 0;

  while (true)
  {
    Console.Write(message);

    if (int.TryParse(Console.ReadLine(), out result) && result > 0)
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не число или некорректное число. Повторите ввод!");
    }
  }

  return result;
}

int[,] InitAndFill2DArray(int rows, int columns)
{
  int[,] matrix = new int[rows, columns];
  Random rnd = new Random();

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      matrix[i, j] = rnd.Next(-10, 10); // [-10; 10)
    }
  }

  return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j],7}");
    }
    Console.WriteLine();
  }
}

void FindAndPrintMeanOfEachColumn(int[,] matrix)
{
  Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");

  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    var sum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      sum = sum + matrix[i, j];
    }

    var mean = (double)sum / matrix.GetLength(0);
    Console.Write("{0,7:f1}", mean);
  }

  Console.WriteLine();
}

Console.WriteLine();
int countOfRows = GetNaturalNumber("Введите количество строк: ");
int countOfColumns = GetNaturalNumber("Введите количество столбцов: ");
int[,] matrix = InitAndFill2DArray(countOfRows, countOfColumns);

Console.WriteLine();
PrintMatrix(matrix);

Console.WriteLine();
FindAndPrintMeanOfEachColumn(matrix);


// The example displays the following output:

// Введите количество строк: 5
// Введите количество столбцов: 5

//      -2     -2    -10     -5     -1
//       3      5      1      4    -10
//      -1     -2      1      3     -6
//      -3     -8      0     -7      1
//       7      7      0      6     -2

// Среднее арифметическое элементов в каждом столбце:
//     0,8    0,0   -1,6    0,2   -3,6