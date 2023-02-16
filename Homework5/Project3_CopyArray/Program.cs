//56. Написать программу копирования массива
Console.WriteLine("Привет! Данная программа предназачена для копирования массива");
System.Console.WriteLine("Введите желаемую длину массива (целым числом):");

int N = InputN();

System.Console.WriteLine("Введите числа в массив: ");
double [] Array = ArrayIniziallization (N);

System.Console.WriteLine("Введен следующий массив: ");
OutputArray (Array);
System.Console.WriteLine();

double [] copiedArray = CopyArray (Array);
System.Console.WriteLine("Скопированный массив: ");
OutputArray (copiedArray);
System.Console.WriteLine();




int InputN ()
{
int x = 0;
Start:
try
{
 x = Convert.ToInt32(Console.ReadLine());
}
catch
{
  System.Console.WriteLine("Ошибка! Вводите целое число больше нуля");
  goto Start;
}
if (x<1)
{
  System.Console.WriteLine("Ошибка! Вводите целое число больше нуля");
  goto Start;
}
return x;
}

double InputNumber ()
{
double x = 0;
Start:
try
{
 x = Convert.ToDouble(Console.ReadLine());
}
catch
{
  System.Console.WriteLine("Ошибка! Вводите число");
  goto Start;
}
return x;
}


double [] ArrayIniziallization (int x)
{
  double [] A = new double [x];
  for (int i = 0; i<x; i++)
  {
    A [i] = InputNumber();
  }
  return A;
}

void OutputArray (double [] a)
{
  for (int i = 0; i<a.Length; i++)
  {
    Console.Write($"{a[i]} ");
  }  
}

double [] CopyArray ( double [] a)
{
 double [] b = new double [a.Length];
 for (int i = 0; i<a.Length; i++)
 {
  b[i] = a[i];
 }
 return b;
}

