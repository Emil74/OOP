using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface ILesson
    {
        string Name { get; }
        string Description { get; }
        void Run();
    }
}
