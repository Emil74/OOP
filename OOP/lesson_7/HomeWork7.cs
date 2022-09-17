using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.lesson_7
{
    public class HomeWork7 : ILesson
    {
        public string Name => "7";

        public string Description => "Домашние задания 1 Урок 7";

        public void Run()
        {

            Console.WriteLine("ACoder -> ABC");
            ACoder coder = new("ABC");
            Console.WriteLine("Encode -> " + coder.Encode());
            Console.WriteLine("Decode - >" + coder.Decode());
            Console.WriteLine("\n" + "BCoder -> ABC");
            BCoder bCoder = new("ABC");
            Console.WriteLine("Encode -> " + bCoder.Encode());
            Console.WriteLine("Decode -> " + bCoder.Decode());

        }
    }
}
