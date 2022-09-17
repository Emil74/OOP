using OOP.lesson_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.lesson_6
{
    public class HomeWork6 : ILesson
    {
        public string Name => "6";

        public string Description => "Домашние задания 6 Урок 6";

        public void Run()
        {
            BankAccaunt b = new BankAccaunt();
            b.Balance = 10;
            b._typeAcaunt = TypeOfBankAccaunt.Credit;
            Console.WriteLine(b.ToString());
            Console.WriteLine(b.GetHashCode());

            BankAccaunt b1 = new BankAccaunt();
            b1.Balance = 120;
            b1._typeAcaunt = TypeOfBankAccaunt.Credit;

            Console.WriteLine(b.Equals(b1));
            Console.WriteLine(b != b1);
            Console.WriteLine(b == b1);
            Console.WriteLine(b.GetHashCode() == b1.GetHashCode());
            Console.ReadLine();

        }
    }
}
