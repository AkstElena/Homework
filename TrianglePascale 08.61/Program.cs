// Задача 61: Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника

//Выполняется в форме двумерного массива

int row = 20; // сколько строк треугольник нужно
int[,] triangle = new int[row, row];
const int cellWidth = 1; // ширина ячейки под один символ треугольника (в зависимости от количества разрядов чисел, когда много строк)

void FillTriangle() // заполнение массива, треугольника
{
  for (int i = 0; i < row; i++) // заполнение еденичек по двум сторонам треугольника, первого столбца строки и второго столбца строки,
  // что не заполняется: по умолчанию ноль
  {
    triangle[i, 0] = 1;
    triangle[i, i] = 1;
  }

  for (int i = 2; i < row; i++) // подсчет следущих элементов суммировнием двух цифр выше в строке
  // что не заполняется: по умолчанию ноль
  {
    for (int j = 1; j <= i; j++)
    {
      triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
    }
  }
}

// void PrintTriangle() // Простое представление, без выравнивания
// {
//   for (int i = 0; i < row; i++)
//   {
//     for (int j = 0; j < row; j++)
//     {
//       if (triangle[i, j] != 0)  // для того чтобы нули не печатались и как раз массив выглядел треугольником
//         Console.Write($"{triangle[i, j],cellWidth}");
//     }
//     Console.WriteLine();
//   }
// }

void Magic()
{
  int col = cellWidth * row; // ширина ячейки умножена на столбец
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j <= i; j++)
    {
      Console.SetCursorPosition(col, i + 1); // делается такой отступ свободных ячеек, чтобы треугольник был равнобедренным
     // if (triangle[i, j] != 0)  Console.Write($"{triangle[i, j],cellWidth}"); // вывод числа треугольника Паскаля
      //if (triangle[i, j] != 0)  Console.Write("*"); // Вывод вместо не нулевого числа звездочки, так как на вывод звезды достаточно одного символа, то cellWidth = 1
      if (triangle[i, j] %2!= 0)  Console.Write("*"); // вывод только нечетных элементов
      col += cellWidth * 2;
    }
    col = cellWidth*row - cellWidth*(i+1);
    Console.WriteLine();
  }
}

FillTriangle();
//PrintTriangle();
Console.ReadLine(); // чтобы перед вводом расширить терминал
Magic();
