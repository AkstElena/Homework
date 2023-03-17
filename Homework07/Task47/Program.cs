// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Promt(string message)
{
  Console.WriteLine(message);
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}

double[,] PrintCreateArray(int m, int n)
{
  double[,] array = new double[m, n];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = Convert.ToDouble(new Random().Next(-9, 10));
      Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
  }
  return array;
}

int rows = Promt("Введите количество строк двумерного массива: ");
int columns = Promt("Введите количество столбцов двумерного массива: ");
Console.WriteLine();
PrintCreateArray(rows, columns);