




//Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
//а) используя склеивание;
//б) используя форматированный вывод;
//   в) используя вывод со знаком $.
//Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.

using System;

namespace Anketa
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Здравствуйте, вам нуэно заполнить небольшую анкету, введите, пожалуйста, имя:  ");
            string name = Console.ReadLine();

            Lib.Pause($"Привет, {name}, теперь введи свою фамилию!  ");
            string sname = Console.ReadLine();

            Lib.Pause("Мне очень интересен твой возраст!  ");
            var age = Convert.ToInt32(Console.ReadLine());

            Lib.Pause("Теперь введи свой рост в сантиметрах!  ");
            double h = Convert.ToInt32(Console.ReadLine());

            Lib.Pause("Скажи же, сколько ты весишь?  ");
            var m = Convert.ToInt32(Console.ReadLine());

            Lib.Calculate(name, sname, age, h, m);

            Lib.Pause("Конец!");

        }


    }

}
