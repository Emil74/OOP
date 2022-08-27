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
            BankAccaunt accaunt = new();
            accaunt.GetAccauntBalance = 1000m;
            accaunt.GetTypeOfAccaunt = TypeOfBankAccaunt.Credit;
            accaunt.Info();

            Console.WriteLine(new string('-', 50));

            BankAccaunt accaunt2 = new();
            accaunt2.GetAccauntBalance = 9000m;
            accaunt2.GetTypeOfAccaunt = TypeOfBankAccaunt.Deposit;
            accaunt2.Info();

            Console.WriteLine(new string('-', 50));

            BankAccaunt accaunt3 = new();
            accaunt3.GetAccauntBalance = 1500m;
            accaunt3.GetTypeOfAccaunt = TypeOfBankAccaunt.Budget;
            accaunt3.Info();

            Console.WriteLine(new string('-', 50));

        }
    }
}
