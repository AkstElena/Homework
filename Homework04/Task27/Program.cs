// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
string message = Console.ReadLine();
int number;

bool isNumeric = int.TryParse(message, out number);

if (isNumeric)
{
  int result = 0;
  for (int count = 0; count < message.Length; count++)
  {
    result = result + number%10;
    number = number/10;
  }
  Console.WriteLine("Сумма всех цифр в числе " + message + " равна " + result); 
}
else Console.WriteLine("Введено не число!");