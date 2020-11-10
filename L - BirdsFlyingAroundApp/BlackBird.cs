using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L___BirdsFlyingAroundApp
{
    //represents a blackbird
    class BlackBird : Bird, IFly
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
        public BlackBird(double avgAge, double speed) : base(avgAge, speed)
        {

        }

        public override string Eat()
        {
            return "Blackbird is eating";
        }

        public override string MakeSound()
        {
            return "Blackbird goes brrrr";
        }

        public string Fly()
        {
            return "Blackbird is flying around";
        }

        public string SetLocation()
        {
            return "Blackbird will fly to Chile";
        }

        public string SetAltitude(double altitude)
        {
            return "Blackbird is at altitude " + altitude + " and is flying at " + Speed + " mph";
        }
    }
}
