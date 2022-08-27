using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.lesson_2
{
    public class HomeWork2 : ILesson
    {
        public string Name => "2";

        public string Description => "Домашние задания 2 Урок 2";

        public void Run()
        {
            BankAccaunt accaunt = new BankAccaunt(1500m, TypeOfBankAccaunt.Credit);
            accaunt.Info();
            Console.WriteLine(new string('-', 50));

            BankAccaunt accaunt1 = new BankAccaunt(TypeOfBankAccaunt.Budget);
            accaunt1.Info();
            Console.WriteLine(new string('-', 50));

            BankAccaunt accaunt2 = new BankAccaunt(1200m);
            accaunt2.Info();

            Console.WriteLine(new string('-', 50));

           
        }
    }
}
