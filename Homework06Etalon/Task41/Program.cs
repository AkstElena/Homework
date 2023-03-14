// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Promt(string message)
{
  System.Console.Write(message);                 // Выводим приглашение ко вводу
  string value = Console.ReadLine();  // Вводим значение
  int result = Convert.ToInt32(value);      // Приводим к числу
  return result;                          // Возвращаем результат
}

int[] InputArray(int lenght)
{
  int [] array = new int [lenght];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = Promt($"Введите {i + 1 }-й элемент: ");
  }
  return array;
}

void PrintArray(int [] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.WriteLine($"a[{i}] = {array[i]}");
  }
}

int CountPositiveNumbers(int [] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
    {
      count++;
    }
  }
  return count;
}

int lenght = Promt("Введите количество элементов > ");
int [] array = InputArray(lenght);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");

