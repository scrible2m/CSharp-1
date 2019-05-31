//Москалев Артем 
//С# 1-1
//Задание 3
//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)).Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
//б) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
//Не пользуюсь Классом, так как не нашел, как на маке сделать ссылку.


using System;

namespace OtXDoY
{
    
    class MainClass
    {

      
        public static void Main(string[] args)
            {
           
             Console.WriteLine("Введите координату Х первой точки: ");
             var x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату Y первой точки: ");
            var y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату Х второй точки: ");
            var x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату Y второй точки: ");
            var y2 = Convert.ToInt32(Console.ReadLine());

            var R = Math.Round(Distance(x1, x2, y1, y2), 2);
            Console.WriteLine($"Расстояние от А до В {R}.");
            Console.ReadKey();
        }


        //Метод
        public static double Distance(int x1, int x2, int y1, int y2)
        {
           return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
         
               
        }
    }
}
