using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.lesson_2
{
    public class BankAccaunt
    {
        static int accaunt_Number = 0;
        decimal Balance;
        TypeOfBankAccaunt _typeAcaunt;

        public BankAccaunt()
        {
            accaunt_Number++;
        }

        public int GetAccuntNumber
        {
            get
            {
                return accaunt_Number;
            }
        }


        public decimal GetAccauntBalance
        {
            get
            {
                return Balance;
            }
            set
            {
                Balance = value;

            }
        }



        public TypeOfBankAccaunt GetTypeOfAccaunt
        {
            get
            {
                return _typeAcaunt;
            }
            set
            {
                _typeAcaunt = value;

            }
        }

        //ДЗ_5

        public void WithDrawMoney(int name, decimal sumMoney)
        {
            if (name == accaunt_Number)
            {
                if (Balance >= sumMoney)
                {
                    Balance -= sumMoney;
                    Console.WriteLine($"Со счёта №{name} снята на: {sumMoney}  Баланс: {Balance} {myRI1.CurrencySymbol}");
                }
                else
                {
                    Console.WriteLine($"На счете №{name} недостаточно денги. Баланс:{Balance} {myRI1.CurrencySymbol}  хотел снят: {sumMoney} {myRI1.CurrencySymbol}");
                }
            }

        }

        public void DepositMoney(int name, decimal sumMoney)
        {
            if (name == accaunt_Number)
            {
                Balance += sumMoney;
                Console.WriteLine($"{sumMoney} на cчет №{name} пополнен.Текущий Баланс: {Balance} {myRI1.CurrencySymbol} ");
            }
        }


        RegionInfo myRI1 = new RegionInfo("en-RU");
        public void Info()
        {

            Console.WriteLine($"Номер счета: {accaunt_Number}\nТип счета: {GetTypeOfAccaunt.Description()}\n" +
                              $"Баланс: { GetAccauntBalance} {myRI1.CurrencySymbol} ");
        }
    }


    public enum TypeOfBankAccaunt
    {
        [Description("Депозит")]
        Deposit,
        [Description("Бюджет")]
        Budget,
        [Description("Кредит")]
        Credit
    }
    static class EnumExtension
    {
        static public string Description(this TypeOfBankAccaunt value)
        {
            DescriptionAttribute? atribute = (DescriptionAttribute)value.GetType()
                                                                        .GetField(value.ToString())
                                                                        .GetCustomAttributes(false)
                                                                        .First();
            return atribute.Description;

        }
    }

}
