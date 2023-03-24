// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Определение условий Петер
// A(0, n) = n + 1
// A(m+1, 0) = A(m, 1)
// A(m+1, n+1) = A(m, A(m+1, n))

// Определение - один из вариантов
// A(0, j) = j + 1
// A(i, 0) = A(i-1, 1) если i > 0; 
// A(i, j) = A(i-1, A(i, j-1)) если i,j > 0;

int FunctionAccerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (m > 0 && n == 0) return FunctionAccerman(m-1, 1);
  else return FunctionAccerman(m - 1, FunctionAccerman(m, n - 1));
}

int m = 3;
int n = 5;
Console.WriteLine($"Функция Аккермана: A({m},{n}) = {FunctionAccerman(m, n)}");


