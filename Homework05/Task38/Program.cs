// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int Promt(string message)
{
  Console.WriteLine(message);
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}

double[] GenerateArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = Convert.ToDouble(new Random().Next(0, 100));
  }
  return array;
}

double Diff(double[] array)
{
  double min = array[0];
  double max = array[0];
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] < min)
      min = array[i];
    if (array[i] > max)
      max = array[i];
  }
  double result = max - min;
  return result;
}

int lenght = Promt("Введите длину массива: ");
double[] newArray = new double[lenght];
Console.WriteLine($"[{String.Join(", ", GenerateArray(newArray))}]");
Console.WriteLine("Разница между максимальным и минимальным элементами массива составляет: " + Diff(newArray));