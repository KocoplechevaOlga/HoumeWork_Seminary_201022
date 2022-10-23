// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void TableSq (int n, int c) 
{
  if (n > 0)
  { 
  while (c <= n)
    {
    Console.WriteLine($"{c,4}   ->   {Math.Pow(c, 3), 4}");
    c++;
    }
  }
 else 
 {
    Console.WriteLine($"Введите число больше 0");
 }
}

Console.WriteLine("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

TableSq(number, count);
