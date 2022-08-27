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

        public void Number()
        {
            accaunt_Number++;
        }
        public void AccauntBalance(decimal _balance)
        {
            Balance = _balance;
        }
        public void AccauntType(TypeOfBankAccaunt typeOfBankAccaunt)
        {
            _typeAcaunt = typeOfBankAccaunt;
        }

        RegionInfo myRI1 = new RegionInfo("en-RU");
        public void Info()
        {


            Console.WriteLine($"Номер счета: {accaunt_Number}\nТип счета: {/*_typeAcaunt.Description()*/_typeAcaunt}\n" +
                              $"Баланс: {/*Balance*/ Balance} {myRI1.CurrencySymbol} ");

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
