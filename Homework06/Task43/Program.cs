// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Promt(string message)
{
  Console.WriteLine(message);
  double number = Convert.ToDouble(Console.ReadLine());
  return number;
}

double b1 = Promt("Введите значение b1: ");
double b2 = Promt("Введите значение b2: ");
double k1 = Promt("Введите значение k1: ");
double k2 = Promt("Введите значение k2: ");

if (k2 != k1)
{
  double x = (b2-b1)/(k1-k2);
  double y = k1 * x +b1;
  Console.WriteLine($"Координаты точки пересечения прямых y = {k1} * х + {b1} и y = {k2} * х + {b2} составят: ({x}, {y})");
}
else if (k2 == k1 && b2 == b1) Console.WriteLine("Прямые совпадают");
else Console.WriteLine("Прямые не пересекаются, так как параллельны");