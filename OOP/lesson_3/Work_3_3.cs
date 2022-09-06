using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.lesson_3
{
    public class Work_3_3
    {
        public static void Lesson_3_3()
        {
            File.WriteAllLines("Name.txt", new[] {
                "Кучма Андрей Витальевич & Kuchma@mail.ru",
                "Мизинцев Павел Николаевич & Pasha@mail.ru"
            });

            List<string> str = new();
            string[] fileLines = File.ReadAllLines("Name.txt");
            foreach (var s in fileLines)
            {
                Console.WriteLine(s);
            }

            for (int i = 0; i < fileLines.Length; i++)
            {
                Console.WriteLine(fileLines[i] + " " + "ID - "+ i);
            }
            str.AddRange(fileLines);
            Console.Write("Введите ID: ");
            int s2 = int.Parse(Console.ReadLine());
            string s1 = str[s2];
            Email.SearchMail(ref s1);
            Console.WriteLine(s1);
        }
    }
}
