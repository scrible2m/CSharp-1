//Москалев Артем 
//С# 1-1
//Задание 4
//Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;
//б) * без использования третьей переменной.
// Вариант Б, на А даже время жалко тратить))

using System;


namespace CSharp_1_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите Х: ");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Y: ");
            var y = Convert.ToInt32(Console.ReadLine());
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine($"После несложных действий мы имеем X = {x}, а Y = {y}.");
        }
    }
}
