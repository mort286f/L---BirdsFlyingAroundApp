using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L___BirdsFlyingAroundApp
{
    //represents a Wood Pecker
    class WoodPecker : Bird, IFly
    {
        private string color;

        public override string Color
        {
            get { return color; }
            protected set { color = value; }
        }
        private double speed;

        public override double Speed
        {
            get { return speed; }
            protected set { speed = value; }
        }
        private double avgAge;

        public override double AvgAge
        {
            get { return avgAge; }
            protected set { avgAge = value; }
        }
        public WoodPecker(double avgAge, double speed) : base(avgAge, speed)
        {

        }

        public override string Eat()
        {
            return "Wood Pecker is eating";
        }

        public override string MakeSound()
        {
            return "Wood Pecker goes brrrrrrrr kykkeliky hak hak ";
        }

        public string Fly()
        {
            return "Wood Pecker is flying around";
        }

        public string SetLocation()
        {
            return "Wood Pecker will fly to Langbortistan";
        }

        public string PeckTree()
        {
            return "Wood Pecker lands on a tree and pecks it like its nothing!";
        }
        public string SetAltitude(double altitude)
        {
            return "Wood Pecker is at altitude " + altitude + " and is flying at " + Speed + " mph";
        }
    }
}
