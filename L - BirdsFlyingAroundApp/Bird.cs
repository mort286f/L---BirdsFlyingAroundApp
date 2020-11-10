using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L___BirdsFlyingAroundApp
{
    //Represents a superclass for all birds
    public abstract class Bird
    {
        public abstract string Color { get; protected set; }
        public abstract double Speed { get; protected set; }
        public abstract double AvgAge { get; protected set; }
        public abstract string Eat();
        public abstract string MakeSound();
        public Bird(double speed, double avgAge)
        {
            this.AvgAge = avgAge;
            this.Speed = speed;
        }
    }
}
