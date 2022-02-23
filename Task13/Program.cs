using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string [] args)
        {
            Building building = new Building("Белинского 5", 80, 14, 12);
            MultiBuilding multiBuilding = new MultiBuilding("Белинского 5", 80, 14, 12, 5);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}