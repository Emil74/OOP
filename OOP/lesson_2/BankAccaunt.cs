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
