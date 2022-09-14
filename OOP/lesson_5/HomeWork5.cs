using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.lesson_5
{
    public class HomeWork5 : ILesson
    {
        public string Name => "5";

        public string Description => "ДЗ__5.1___5.2";

        public void Run()
        {
            RationalNumber rationalNumber = new RationalNumber(1, 2);
            Console.WriteLine(rationalNumber.ToString());

            RationalNumber rational2 = new RationalNumber(3, 4);
            RationalNumber rationalNumber3 = new RationalNumber();

            rationalNumber3 = rationalNumber + rational2;
            Console.WriteLine(rationalNumber3);
            Console.WriteLine(rationalNumber.Equals(rationalNumber));
        }
    }
}
