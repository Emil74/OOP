using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.lesson_3
{
    public class HomeWork_3 : ILesson
    {
        public string Name => "3";

        public string Description => "Домашние задания 3.2 , 3.3 Урок 3";

        public void Run()
        {
            Console.Write("Ввдите дз (3.2  +  3.3) --> ");
            string work = Console.ReadLine();

            switch (work)
            {
                case "3.2":
                    Work_3_2.Str();
                    break;
                case "3.3":
                    Work_3_3.Lesson_3_3();
                    break;
                default:
                    break;
            }
        }
    }
}
