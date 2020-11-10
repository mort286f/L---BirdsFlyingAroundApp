using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L___BirdsFlyingAroundApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Chicken chicken = new Chicken(8, 666);
            BlackBird blackBird = new BlackBird(6, 99);
            WoodPecker woodPecker = new WoodPecker(9, 120);
            Console.WriteLine("Chicken:");
            Console.WriteLine(chicken.Eat());
            Console.WriteLine(chicken.MakeSound());
            Console.WriteLine(chicken.Fly());
            Console.WriteLine(chicken.SetLocation());
            Console.WriteLine(chicken.SetAltitude(90));
            Console.WriteLine("\rBlack Bird:");
            Console.WriteLine(blackBird.Eat());
            Console.WriteLine(blackBird.MakeSound());
            Console.WriteLine(blackBird.Fly());
            Console.WriteLine(blackBird.SetLocation());
            Console.WriteLine(blackBird.SetAltitude(90));
            Console.WriteLine("\rWood Pecker:");
            Console.WriteLine(woodPecker.Eat());
            Console.WriteLine(woodPecker.MakeSound());
            Console.WriteLine(woodPecker.Fly());
            Console.WriteLine(woodPecker.SetLocation());
            Console.WriteLine(woodPecker.SetAltitude(90));
            Console.WriteLine(woodPecker.PeckTree());
            Console.ReadLine();
        }
    }
}
