using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class MultiBuilding : Building
    {
        int Number { get; set; }
        public MultiBuilding(string adress, int length, int width, int height, int number)
            : base(adress, length, width, height)
        {
            Number = number;
        }
        public string Print()
        {
            string result = base.Print();
            result += $", { Number} этажа";  
            return result;  
        }

    }
}
