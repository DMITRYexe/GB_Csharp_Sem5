/* 51. С клавиатуры вводится число N. Затем вводятся N чисел. 
Определить сколько чисел больше 0 введено с клавиатуры */

namespace MainSpace
{
  namespace UnderSpace // в прострастве имен можно создавать подпространства
  {
    class Training // в прострастве имен обяз. задать класс
    {
      static void Main() // задаем точку входа
      {
        System.Console.WriteLine("Введите N");
        int N = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Вводите числа");
        int k=0;
        for (int i = 0; i<N; i++) // вводим числа N раз
        {
          int n = int.Parse(Console.ReadLine());
          if (n>0) k++;
        }
        System.Console.Write("Ответ:");
        System.Console.WriteLine(k);
        MainSpace.UnderSpace.Training.Main(); // зацикливание программы
      }
    }
  }
}