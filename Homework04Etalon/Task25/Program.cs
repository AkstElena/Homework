// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Promt(string message)
{
  Console.Write(message);                 // Выводим приглашение ко вводу
  string readInput = Console.ReadLine();  // Вводим значение
  int result = int.Parse(readInput);      // Приводим к числу
  return result;                          // Возвращаем результат
}

int Power(int powerBase, int exponent)
{
  int power = 1;
  for (int i = 0; i < exponent; i++)
  {
    power *= powerBase;
  }
  return power;
}

bool ValidateExponent(int exponent)
{
  if (exponent <0)
  {
    Console.WriteLine("Показатель не должен быть меньше нуля");
    return false;
  }
  return true;
}

int powerBase = Promt("Введите основание: ");
int exponent = Promt("Введите степень: ");
if (ValidateExponent(exponent))
{
  Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}