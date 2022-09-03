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

        public string Description => "Домашние задания 2 Урок 2 + Урок 3 дз 3.1 ";

        public void Run()
        {
            #region ДЗ_2.1

            
            BankAccaunt accaunt_1=new BankAccaunt();
            accaunt_1.GetAccauntBalance = 994.45m;
            accaunt_1.GetTypeOfAccaunt = TypeOfBankAccaunt.Budget;

            BankAccaunt accaunt_2 = new BankAccaunt();
            accaunt_2.GetAccauntBalance = 740.27m;
            accaunt_2.GetTypeOfAccaunt = TypeOfBankAccaunt.Credit;

            BankAccaunt.DepostiMOneyNumberAccaunt(accaunt_2,accaunt_1,100);

            Console.ReadLine();


            #endregion



            BankAccaunt accaunt = new();
            accaunt.GetAccauntBalance = 1000m;
            accaunt.GetTypeOfAccaunt = TypeOfBankAccaunt.Credit;
            accaunt.Info();

            Console.WriteLine(new string('-', 50));

            accaunt.WithDrawMoney(accaunt.GetAccuntNumber, 1000);
            accaunt.DepositMoney(accaunt.GetAccuntNumber, 5000);
            Console.WriteLine(new string('-', 50));


            BankAccaunt accaunt2 = new();
            accaunt2.GetAccauntBalance = 9000m;
            accaunt2.GetTypeOfAccaunt = TypeOfBankAccaunt.Deposit;
            accaunt2.Info();

            Console.WriteLine(new string('-', 50));

            accaunt2.WithDrawMoney(accaunt.GetAccuntNumber, 10000);
           
            Console.WriteLine(new string('-', 50));

            BankAccaunt accaunt3 = new();
            accaunt3.GetAccauntBalance = 1500m;
            accaunt3.GetTypeOfAccaunt = TypeOfBankAccaunt.Budget;
            accaunt3.Info();

            Console.WriteLine(new string('-', 50));

            accaunt3.WithDrawMoney(accaunt3.GetAccuntNumber, 1000);
            accaunt3.DepositMoney(accaunt3.GetAccuntNumber, 1000);

        }
    }
}
