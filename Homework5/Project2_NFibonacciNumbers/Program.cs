// 54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1
Console.WriteLine("Привет! Данная программа выводит первых N чисел Фибоначчи");
System.Console.WriteLine("Введите N, где N - целое число больше нуля");
int N = InputN ();
int a = 0;
int b = 1;
if (N == 1) FirstFib(a);
if (N == 2) SecondFib(a, b);
if (N > 2) MoreThen2DFibDigits (a,b, N);




int InputN ()
{
int x =0;
Start:
try
{
x = Convert.ToInt32(Console.ReadLine());
}
catch
{
  System.Console.WriteLine("Ошибка! Введите целое число");
  goto Start;
}
if (x < 1)
{
    System.Console.WriteLine("Ошибка! Введите число больше 0");
  goto Start;
}
return x;
}

void FirstFib (int x)
{
System.Console.WriteLine($"Числа Фибоначчи из заданного диапазона: {x}");
}

void SecondFib (int x, int y)
{
  System.Console.WriteLine($"Числа Фибоначчи из заданного диапазона: {x} {y}");

}

void MoreThen2DFibDigits (int x, int y, int amount)
{
  int z;
System.Console.Write($"Числа Фибоначчи из заданного диапазона: {x} {y}");
for ( int i = 0; i < N-2; i++)
{
  z= x + y;
  System.Console.Write($" {z}");
  x = y;
  y = z;
}
}

