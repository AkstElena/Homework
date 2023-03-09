// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Promt (string message)
{
  Console.WriteLine(message);
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}

int numberA = Promt("Введите число А");
int numberB = Promt("Введите число В");

int Power (int numberA, int numberB)
{
  int result = 1;
  for (int count =1; count <= numberB; count++)
  {
    result = result * numberA;
  }
  return result;
}

Console.WriteLine($"{numberA} в степени {numberB} равно {Power(numberA, numberB)}");