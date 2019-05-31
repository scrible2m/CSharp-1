
//Москалев Артем 
//С# 1-1
//Задание 5
//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) * Сделать задание, только вывод организовать в центре экрана.
// в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).



using System;

namespace NameInCenter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           
            WriteInPoint("Москалев Артем Дмитриевич, город Москва, 32 года.");
        }


        //Метод
        public static void WriteInPoint(string msg)
        {
            var x = Console.WindowWidth / 2 - msg.Length / 2;
            var y = Console.WindowHeight / 2;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
    }
}
