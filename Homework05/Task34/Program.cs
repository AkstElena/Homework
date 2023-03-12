// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Promt(string message)
{
  Console.WriteLine(message);
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}

int[] GetArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(100, 1000);
  }
  return array;
}

int EvenNumbers(int[] array)
{
  int count = 0;
  for (int index = 0; index < array.Length; index++)
  {
    if (array[index] % 2 == 0)
      count = count + 1;
  }
  return count;
}

int lenght = Promt("Введите длину массива: ");
int[] newArray = new int[lenght];
GetArray(newArray);
Console.WriteLine($"[{String.Join(", ", newArray)}]");
Console.WriteLine($"Количество четных чисел в массиве: {EvenNumbers(newArray)}");
