using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.lesson_4
{
    public class Building
    {
        private static short _buildingID = 0;
        private double _height;
        private int _numberOfStoreys;
        private int _numberOfApartments;
        private int _entrances;

        public void Add(double height, int numberOfStoreys, int numberOfApartments, int entrances)
        {
            _buildingID++;
            _height = height;
            _numberOfStoreys = numberOfStoreys;
            _numberOfApartments = numberOfApartments;
            _entrances = entrances;

        }

        public void FlorHeight(double height, int numberOfStoreys)
        {
            double _florHeight = height / numberOfStoreys;
            string result = string.Format("{0:f1}м", _florHeight);
            Console.WriteLine("Высоты этажа: " + result);
        }

        public void TheNumberOfApartmentsInTheEntrance(int numberOfApartaments, int numberOfStoreys, int enterances)
        {

            int _numberOfApartmentsInTheEntrance = numberOfApartaments / numberOfStoreys - enterances;
            Console.WriteLine($"Количества квартир в подъезде: {_numberOfApartmentsInTheEntrance}");
        }

        public void TheNumberOfApartmentsOnTheFloor(int numberOfApartaments, int numberOfStoreys)
        {
            int _umberOfApartmentsOnTheFloor = numberOfApartaments / numberOfStoreys;
            Console.WriteLine($"Количества квартир на этаже: {_umberOfApartmentsOnTheFloor}");

        }

       

        public void Print()
        {
            Console.WriteLine(
                $"Уникалный номер здания: {_buildingID} Высота: {_height} Этажность: {_numberOfStoreys} " +
                $"Количество квартир: {_numberOfApartments} Подъездов: {_entrances}");
        }
    }
}
