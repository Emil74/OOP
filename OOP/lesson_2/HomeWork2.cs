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
            BankAccaunt bankAcaunt = new();
            bankAcaunt.AccauntType(TypeOfBankAccaunt.Credit);
            bankAcaunt.AccauntBalance(100.120m);
            bankAcaunt.Number();
            bankAcaunt.Info();

            Console.WriteLine(new string('-', 50));

            BankAccaunt bankAcaunt2 = new();
            bankAcaunt2.AccauntType(TypeOfBankAccaunt.Budget);
            bankAcaunt2.AccauntBalance(912.145m);
            bankAcaunt.Number();
            bankAcaunt2.Info();

            Console.WriteLine(new string('-', 50));

            BankAccaunt bankAccaunt3 = new();
            bankAccaunt3.AccauntType(TypeOfBankAccaunt.Deposit);
            bankAccaunt3.AccauntBalance(100000m);
            bankAcaunt.Number();
            bankAccaunt3.Info();
        }
    }
}
