using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Комсомольский проспект дом 59", 90, 30, 16);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("Улица Ленина 30", 42, 18, 9, 2);
            Console.WriteLine(multiBuilding.Print());   
            Console.ReadKey();  

        }
    }
}
