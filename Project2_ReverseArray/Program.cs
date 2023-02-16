// Перевернуть массив (было 1 2 3, стало 3 2 1)
int [] a = { 3, 4 , 2 , 1, 5};
int t;
Console.WriteLine("Вывод первой половины массива");
for (int i=0;i<a.Length/2; i++) // делим массив пополам
{
System.Console.WriteLine(a[i]);
}
Console.WriteLine("Вывод первой половины массива (с конца)");
for (int i=0;i<a.Length/2; i++)
{
System.Console.WriteLine(a[a.Length-i-1]); 
}
for (int i=0;i<a.Length/2; i++) // переворот массива
{
  t=a[i];
  a[i]=a[a.Length-i-1];
  a[a.Length-i-1]=t;
}
Console.WriteLine("Результат переворота");
for (int i=0;i<a.Length; i++) // вывод ответа
{
  System.Console.Write(a[i]);
}