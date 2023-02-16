// 50. Выяснить являются ли три числа сторонами треугольника
Console.WriteLine("Введите длины сторон:");
Console.WriteLine("Сторона а:");
int a=0;
InputNumbers(ref a);
Console.WriteLine("Сторона b:");
int b = 0;
InputNumbers(ref b);
Console.WriteLine("Сторона c:");
int c = 0;
InputNumbers(ref c);
System.Console.WriteLine("Введеные длины сторон: ");
Console.WriteLine($"{a} {b} {c}");

if (a+b > c && a+c >b && c+b>a)
System.Console.WriteLine("Условие выполняется");
else System.Console.WriteLine("Условие не выполняется");




int InputNumbers(ref int y)
{
  int x = Convert.ToInt32(Console.ReadLine());
  y=x;
  return y;
}
