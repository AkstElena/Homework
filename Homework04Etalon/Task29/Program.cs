// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Ввод данных с экрана
int Promt(string message)
{
  Console.Write(message);
  string readInput = Console.ReadLine();
  int result = int.Parse(readInput);
  return result;
}

// метод для получения случайных чисел в массиве
int [] GenerateArray(int length, int minValue, int maxValue)
{
  int [] array = new int [length]; // объявляем массив
  Random random = new Random();
  for (int i = 0; i < length; i ++)
  {
    array[i] = random.Next(minValue, maxValue+1);
  }
  return array;
} 

// Печать массива

void PrintArray(int [] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length-1; i ++)
  {
    Console.Write($"{array[i]}, ");
  }
  Console.Write($"{array[array.Length-1]}]");
}

int length = Promt("Длина массива: ");
int min = Promt("Начальное значение, для диапазона случайного числа: ");
int max = Promt("Конечное значение, для диапазона случайного числа: ");
int [] array = GenerateArray(length, min, max);
PrintArray(array);


