using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Bot : Robot
    {
        public Bot() { }

        public Bot(string name, int weight, byte[] coordinates) : base(name, weight, coordinates)
        {
            //base.printValues();
        }

        public override void printValues()
        {
            System.Console.WriteLine(this.Name + " weight:" + this.Weight + ", made from " + this.Material + ". Coordinates: ");
            foreach (byte el in this.Coordinates)
            System.Console.WriteLine(el);
        }
    }
}
