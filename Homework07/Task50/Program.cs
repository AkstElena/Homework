// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int Promt(string message)
{
  Console.WriteLine(message);
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}

int[] IndexArray(string message)
{
  Console.WriteLine(message);
  string[] input = Console.ReadLine().Split(" ");
  int[] indexOfPosition = Array.ConvertAll(input, s => int.Parse(s));
  return indexOfPosition;
}

int[,] CreateAndPrintArray(int m, int n)
{
  int[,] matrix = new int[m, n];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(0, 10);
      Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
  }
  return matrix;
}

int FindPosition(int[,] array, int[] index)
{
  int number = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (i == index[0] - 1 && j == index[1] - 1)
      {
        number = array[i, j];
      }
    }
  }
  return number;
}

int rows = Promt("Введите количество строк двумерного массива: ");
int columns = Promt("Введите количество столбцов двумерного массива: ");
int[] index = IndexArray("Введите позицию элемента в формате: строка столбец (через пробел) > ");
Console.WriteLine();
int number = FindPosition(CreateAndPrintArray(rows, columns), index);
Console.WriteLine();
if (number != 0)
  Console.WriteLine($"Число с данной позицией присутствует в двумерном массиве и равно {number}");
else Console.WriteLine("Число с данной позицией отсутствует в двумерном массиве");



// Булевое значение, не выдает число. ? как сделать и булевое и на выходе число в одном методе
// bool FindPosition(int[,] array, int[] index)
// {
//   int number = 0;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (i == index[0] && j == index[1])
//       {
//         number = array [i, j];
//         return true;
//       }
//     }
//   }
//   return false;
// }

