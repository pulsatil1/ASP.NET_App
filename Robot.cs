using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Robot : IRun, IJump
    {
        private static int count;
        private string name;
        private int weight;
        private byte[] coordinates;
        private string material = "Metal";
        protected string surname;

        public int Weight
        {
            get
            {
                Console.WriteLine("Результат: ");
                return this.weight + 100;
            }
            set
            {
                if (value < 1)
                    this.weight = 1;
                else if (value > 5000)
                    this.weight = 5000;
                else
                    this.weight = value;
            }
        }

        public string Name { get {
                return name;
            }
            private set {} }

        public string Material
        {
            get
            {
                return material;
            }
            private set { }
        }

        public byte[] Coordinates
        {
            get
            {
                return coordinates;
            }
            private set { }
        }

        public int Width { get; set; }
        public float speed { get; set; }
        public float y { get; set; }

        public Robot(string name, int weight, byte[] coordinates)
        {
            this.setValues(name, weight, coordinates);
            count++;
        }

        public Robot(string name)
        {
            this.name = name;
            count++;
        }

        public Robot()
        {
            count++;
        }
        public void setValues(string name, int weight, byte[] coordinates)
        {
            this.name = name;
            this.weight = weight;
            this.coordinates = coordinates;
        }

        public abstract void printValues();
        //{
        //    System.Console.WriteLine(name + " weight:" + weight + ", made from " + material + ". Coordinates: ");
        //    foreach (byte el in coordinates)
        //        System.Console.WriteLine(el);
        //}

        public static void printCount()
        {
            //System.Console.WriteLine("Count: "+ count);
        }

        public void RobotRun()
        {
            Console.WriteLine("Robot is running now!");
        }

        public void Jump()
        {
            Console.WriteLine("Robot is jumping now!");
        }
    }
}
