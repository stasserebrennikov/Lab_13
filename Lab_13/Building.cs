using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Building
    {
        string Address;
        int Length { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        public Building(string adress, int length, int width, int height)
        {
            Address = adress;
            Length = length;
            Width = width;
            Height = height;
        }
        public string Print()
        {
            return $"{Address}, длина здания {Length} метров, ширина здания {Width}  метров, высота здания {Height} метров"; 
        }






    }
}
