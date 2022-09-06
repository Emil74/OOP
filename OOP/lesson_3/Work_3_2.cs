using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.lesson_3
{
    public class Work_3_2
    {
        public static void Str()
        {
            Console.Write("Введите значение: ");
            string name = Console.ReadLine();
            string name1 = null;


            for (int i = name.Length - 1; i >= 0; i--)
            {

                Console.Write(name[i]);
            }
        }
    }
}
