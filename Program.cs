// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNumbers(int n)
// {
//     if(n >= 1)
//     {
//         Console.Write(n + " ");
//         ShowNumbers(n-1);
        
//     }
// }

// Console.WriteLine("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowNumbers(n);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int InputNumber(string input)
// {
//      Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
//  }

// void PrintSum(int m, int n, int sum)
//  {
//      sum = sum + n;
//      if (n <= m)
//     {
//          Console.Write($" {sum} ");
//          return;
//      }
//      PrintSum(m, n - 1, sum);

//  }
//  int m = InputNumber("Input M: ");
//  int n = InputNumber("Input N: ");
//  int temp = m;

//  if (m > n)
//  {
//      m = n;
//      n = temp;
//  }
//  Console.Write($"{m}, {n} ->");
//  PrintSum(m, n, temp = 0);

//  Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int m = InputInt("Input M: ");
// int n = InputInt("Input N: ");
// Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     if (m > 0 && n == 0)
//         return Akkerman(m - 1, 1);
//     else
//         return Akkerman(m - 1, Akkerman(m, n - 1));
// }