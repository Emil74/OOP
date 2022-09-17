using OOP.lesson_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.lesson_4
{
    public class HomeWork_4 : ILesson
    {
        public string Name => "4";

        public string Description => "Домашние задания 4 Урок 4";

        public void Run()
        {
            Console.Write("Ввдите дз (4.1  +  4.2) --> ");
            string? str = Console.ReadLine();

            switch (str)
            {
                case "4.1":
                    #region 4.1
                    var building = new Building();
                    building.Add(150, 50, 300, 2);
                    building.Print();
                    building.FlorHeight(150, 50);
                    building.TheNumberOfApartmentsInTheEntrance(300, 50, 2);
                    building.TheNumberOfApartmentsOnTheFloor(300, 50);
                    Console.WriteLine();

                    var building2 = new Building();
                    building2.Add(20, 5, 30, 1);
                    building2.Print();
                    #endregion
                    break;
                case "4.2":
                    #region 4.2
                    var building_1 = new Building();
                    building_1.CreatorBuilding(150, 50, 300, 2);

                    var building_2 = new Building();
                    building_2.CreatorBuilding(20, 5, 30, 1);

                    var building_3 = new Building();
                    building_3.CreatorBuilding(70, 30, 150, 2);

                    building_3.PrintBuild();

                    Console.WriteLine();

                    building_3.DeleteBuild(2);
                    building_3.PrintBuild();
                    #endregion
                    break;
            }
        }
    }
}
