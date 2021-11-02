using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Killer : Robot
    {
        public int Health { get; set; }

        public Killer() { }

        public Killer(string name, int weight, byte[] coordinates, int health) : base(name,weight,coordinates) {
            this.Health = health;
            //base.printValues();
        }

        public override void printValues()
        {
            Console.WriteLine(this.Name + " health: " + this.Health);
        }

        public void Lazer()
        {
            this.surname = "Petrovich";
            Console.WriteLine(this.surname + " in Lazertag");
        }
    }
}
