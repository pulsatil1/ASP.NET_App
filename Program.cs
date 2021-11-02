using System;
using System.Collections.Generic;

namespace ConsoleApp2 
{
    class Program
    {
        static void Main()
        {
            //Bot bot = new Bot("Bot", 800, new byte[] { 0, 0, 1 });
            //bot.printValues();

            //Killer killer = new Killer("Killer", 999, new byte[] { 0, 9, 1 },100);
            ////killer.setValues();
            //killer.printValues();
            //killer.Lazer();

            //Bot bot1 = new Bot();
            //bot1.Weight = -100;
            //Console.WriteLine(bot1.Weight);

            //bot1.Width = -100;
            //Console.WriteLine(bot1.Width);

            //Robot.printCount();

            //List<Killer> robots = new List<Killer>();
            //robots.Add(new Killer("Alex", 400, new byte[] { 0, 0, 1 },100));
            //robots.Add(new Killer("Bob", 1400, new byte[] { 0, 0, 2 },100));
            //robots.Add(new Killer("Patrick", 700, new byte[] { 0, 0, 3 },100));
            //robots.Add(new Killer("Ugin", 700, new byte[] { 0, 0, 4 },100));

            //foreach(Robot obj in robots)
            //{
            //    int num = 9;
            //        string _numS = Convert.ToString(num);
            //    if (_numS is string)
            //        Console.WriteLine(obj.Name);
            //}
            Multiply(8);
        }

        public static void Multiply(int a, int b, int c)
        {
            int res = a / (b+c);
            Console.WriteLine("Result: "+res);
        }

        public static void Multiply(float a, float b)
        {
            float res = a * b;
            Console.WriteLine("Result: " + res);
        }

        public static void Multiply(int a)
        {
            int res = a * a;
            Console.WriteLine("Result: " + res);
        }
    }

}