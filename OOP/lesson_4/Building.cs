using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.lesson_4
{
    public class Building:ICreator
    {
        private static short _buildingID = 0;
        private double _height;
        private int _numberOfStoreys;
        private int _numberOfApartments;
        private int _entrances;

        private static Hashtable building = new();
        private static ICollection key = building.Keys;

        public void CreatorBuilding(double height, int numberOfStoreys, int numberOfApartments, int entrances)
        {

            Building b = new();
            b._height = height;
            b._numberOfStoreys = numberOfStoreys;
            b._numberOfApartments = numberOfApartments;
            b._entrances = entrances;

            building.Add(++_buildingID, b);
        }

        public void DeleteBuild(int id)
        {
            for (int i = 1; i <= building.Keys.Count; i++)
            {
                if (i.Equals(id))
                {
                    if (building.ContainsKey(id))
                        building.Remove(building[i]);

                    break;

                }

            }
        }

        private static ArrayList? _ar;
        public void PrintBuild()
        {
            _ar = new ArrayList(key);
            _ar.Sort();

            //var dict = building.Cast<DictionaryEntry>().ToDictionary(d =>
            //    d.Key).OrderBy(e => e.Value);

            foreach (var city in _ar)
            {
                var cityName = (Building)building[city];
                Console.WriteLine(
                    $"Уникалный номер здания: {city} Высота: {cityName._height} Этажность: {cityName._numberOfStoreys} " +
                    $"Количество квартир: {cityName._numberOfApartments} Подъездов: {cityName._entrances}");

            }
        }


        #region Work_4.1

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

        
        #endregion
    }
}
