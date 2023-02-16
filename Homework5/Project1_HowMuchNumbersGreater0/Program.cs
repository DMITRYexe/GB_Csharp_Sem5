/* 50. С клавиатуры вводится число N. Затем вводятся N чисел. 
Определить сколько чисел больше 0 введено с клавиатуры */

Console.WriteLine("Привет! Эта программа вывод числа , которые больше 0.");
System.Console.WriteLine("Введите количество чисел:");
int a = InputN();
int j=0;
NumbersIniziallization (ref j);
System.Console.WriteLine($"Колличество цифр больше нуля: {j}");








int InputN() 
{
  int x = 0;
  Start:
  try
  {
    x = Convert.ToInt32(Console.ReadLine());
  }
  catch
  {
    System.Console.WriteLine("Ошибка! Введите целое число больше 0");
  }
  if (x<1) 
  {
    System.Console.WriteLine("Ошибка! Введите целое число больше 0");
    goto Start;
  }
  return x;
}

double InputNumber()
{
  double number = 0;
  Start:
  try
  {
  number = Convert.ToDouble(System.Console.ReadLine());
  }
  catch
  {
    System.Console.WriteLine("Ошибка! Введите число");
    goto Start;
  }
  return number;
}

int NumbersIniziallization (ref int y)
{
for (int i = 0; i<a; i++)
{
  System.Console.WriteLine($"Введите {i+1} число:");
  double x=InputNumber();
  if (x > 0) j++;
}
return j;
}
