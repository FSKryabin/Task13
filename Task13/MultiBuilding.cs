using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    sealed class MultiBuilding:Building
    {
        double floors;

        public MultiBuilding(string address, double lenght, double widght, double height, double floors)
             :base(address, lenght, widght, height)
            {
            this.floors = floors;
            }
         
        public new string Print()
        {
            string result = base.Print();
            result += $"\tКоличесво этажей: {floors}";
            return result;
        }
    }
}
