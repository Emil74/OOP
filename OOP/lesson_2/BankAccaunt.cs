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
       public static int accaunt_Number = 0;
       public decimal Balance;
       public TypeOfBankAccaunt _typeAcaunt;


        #region ДЗ_6
        
        public static bool operator ==(BankAccaunt accaunt1, BankAccaunt accaunt2)
        {
            return (accaunt1.Balance == accaunt2.Balance) && (accaunt1._typeAcaunt == accaunt2._typeAcaunt);

        }

        public static bool operator !=(BankAccaunt accaunt1, BankAccaunt accaunt2)
        {
            return !(accaunt1 == accaunt2);
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is BankAccaunt))
                return false;

            var accaunt = (BankAccaunt)obj;

            return (accaunt.Balance == this.Balance) & (accaunt._typeAcaunt == this._typeAcaunt);
        }

        public override string ToString()
        {
            return $"Balance: {Balance}  TypeAccaunt: {_typeAcaunt}";
        }

        public override int GetHashCode()
        {
            return string.Format("{0} {1}", Balance, _typeAcaunt).GetHashCode();
        }

        #endregion

        #region MyRegion


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



        static RegionInfo myRI1 = new RegionInfo("en-RU");
        public void Info()
        {

            Console.WriteLine($"Номер счета: {accaunt_Number}\nТип счета: {GetTypeOfAccaunt.Description()}\n" +
                              $"Баланс: {GetAccauntBalance} {myRI1.CurrencySymbol} ");
        }




        public static void DepostiMOneyNumberAccaunt(BankAccaunt numberAccaunt1, BankAccaunt numberAccaunt2,
              decimal sum)
        {
            if (numberAccaunt1.GetAccauntBalance >= sum)
            {
                numberAccaunt1.GetAccauntBalance -= sum;

                numberAccaunt2.GetAccauntBalance += sum;

                Console.WriteLine(
                    $"Баланс {numberAccaunt2.GetAccauntBalance - sum} {myRI1.CurrencySymbol} ---> {sum} {myRI1.CurrencySymbol} на cчет №{numberAccaunt2.GetAccuntNumber} пополнен." +
                    $"Текущий Баланс: {numberAccaunt2.GetAccauntBalance} {myRI1.CurrencySymbol} ");
            }
            else
            {
                Console.WriteLine($"На счете №{numberAccaunt1.GetAccuntNumber} недостаточно денги. " +
                    $"Баланс:{numberAccaunt1.GetAccauntBalance} {myRI1.CurrencySymbol}");

                ;
            }



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
    #endregion
}
