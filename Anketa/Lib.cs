//Москалев Артем 
//С# 1-1
//Задание 6
//* Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
//Из за того, что не нашел в студии Ссылку, не особо тут что делал...


using System;
namespace Anketa
{
    public class Lib
    {


        public static void Pause()
            {
                Console.ReadKey();
            }


        public static void Pause(string msg)
            {
                Console.Write(msg);
            }

 


        public static void Print(string msg)
            {
                Console.WriteLine(msg);
            }

        public static void WriteLn(string z)
            {
                Console.WriteLine(z);
            }

        public static void Calculate(string name, string sname,  int age, double h, int m)
            {
                 h = h / 100;
                double index = (m / (h * h));
                index = Math.Round(index, 2);
                if (index > 25)
                    {

                        Print(name + " " + sname + ", возраст твой " + age + ", рост " + h + ", вес " + m + ", пора худеть! Индекс массы " + index + "!");
                        Console.WriteLine("{0} {1}, возраст твой {2}, рост {3}, вес {4}, пора худеть! Индекс массы {5}!", name, sname, age, h, m, index);
                        Print($"{name} {sname}, возраст твой {age}, рост {h}, вес {m}, пора худеть! Индекс массы {index}!");
                    }
                else
                    {
                        Print(name + " " + sname + ", возраст твой " + age + ", рост " + h + ", вес " + m + ", ты в отличной форме! Индекс массы" + index + "!");
                        Console.WriteLine("{0} {1}, возраст твой {2}, рост {3}, вес {4}, ты в отличной форме! Индекс массы {5}!", name, sname, age, h, m, index);
                        Pause($"{name} {sname}, возраст твой {age}, рост {h}, вес {m}, ты в отличной форме! Индекс массы {index}!");
                    }
            }

    }
}
