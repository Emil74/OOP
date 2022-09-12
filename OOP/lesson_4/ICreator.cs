using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.lesson_4
{
    internal interface ICreator
    {
        public void CreatorBuilding(double height, int numberOfStoreys, int numberOfApartments, int entrances);
        public void DeleteBuild(int id);
        public void PrintBuild();
    }
}
