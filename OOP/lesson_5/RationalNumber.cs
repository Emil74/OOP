using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.lesson_5
{
    class RationalNumber
    {
        private int numerator;              // Числитель
        private int denominator;            // Знаменатель

        // конструктор
        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("В знаменателе не может быть нуля");
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public RationalNumber()
        {

        }
        // Вызов первого конструктора со знаменателем равным 1
        public RationalNumber(int number)
            : this(number, 1)
        { }


        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.numerator + b.numerator, a.denominator + b.denominator);
        }

        // Перегрузка оператора "Равенство" для двух дробей
        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            return a.numerator == b.numerator && a.denominator == b.denominator;
        }

        // Перегрузка оператора "Равенство" для дроби и числа
        public static bool operator ==(RationalNumber a, int b)
        {
            return a == new RationalNumber(b);
        }

        // Перегрузка оператора "Неравенство" для двух дробей
        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            return !(a == b);
        }

        // Перегрузка оператора "Неравенство" для дроби и числа
        public static bool operator !=(RationalNumber a, int b)
        {
            return a != new RationalNumber(b);
        }

        // Equals()
        public override bool Equals(object? obj)
        {
            if (!(obj is RationalNumber))
            {
                return false;
            }

            var number = (RationalNumber)obj;
            return numerator == number.numerator &&
                   denominator == number.denominator;
        }


        // Перегрузка оператора ">" для двух дробей
        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            return (a.numerator > b.numerator) && (a.denominator > b.denominator);
        }



        // Перегрузка оператора "<" для двух дробей
        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            return (a.numerator < b.numerator) && (a.denominator < b.denominator);
        }

        // Перегрузка оператора ">=" для двух дробей
        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            return (a.numerator >= b.numerator) && (a.denominator >= b.denominator);
        }

        // Перегрузка оператора ">=" для дроби и числа
        public static bool operator >=(RationalNumber a, int b)
        {
            return a >= new RationalNumber(b);
        }

        // Перегрузка оператора "<=" для двух дробей
        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            return (a.numerator <= b.numerator) && (a.denominator <= b.denominator);
        }
        // Перегрузка оператора "<=" для дроби и числа
        public static bool operator <=(RationalNumber a, int b)
        {
            return a <= new RationalNumber(b);
        }



        // Перегрузка оператора "++"
        public static RationalNumber operator ++(RationalNumber a)
        {
            a.numerator++;
            a.denominator++;
            return a;
        }

        // Переопределение метода ToString
        public override string ToString()
        {
            if (numerator == 0)
            {
                return "0";
            }

            if (numerator == denominator)
            {
                return "1";
            }
            if (denominator == 1)
            {
                return numerator.ToString();
            }
            return numerator + "/" + denominator;
        }
    }
}
