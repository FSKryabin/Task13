using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Building
    {
        string address;
        double lenght;
        double widght;
        double height;

        public Building(string address, double lenght, double widght, double height)
        {
            this.address = address;
            this.lenght = lenght;
            this.widght = widght;
            this.height = height;
        }
        public string Print()
        {
           return $"Параметры здания:\n \tАдрес здания:ул.{address}\n \tДлина здания:{lenght}м\n \tШирина здания{widght}м\n \tВысота здания:{height}м\n";
        }
    }
}
