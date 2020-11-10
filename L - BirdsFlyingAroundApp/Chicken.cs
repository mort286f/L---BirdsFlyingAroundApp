using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L___BirdsFlyingAroundApp
{
    //represents a chicken
    class Chicken :Bird, IFly
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
        public Chicken(double avgAge, double speed) : base(avgAge, speed)
        {

        }

        public override string Eat()
        {
            return "Chicken is eating";
        }

        public override string MakeSound()
        {
            return "Chicken goes brrrrrrrrrrr kuk kuk";
        }

        public string Fly()
        {
            return "Chicken is flying around";
        }

        public string SetLocation()
        {
            return "Chicken will fly two meters forward";
        }

        public string SetAltitude(double altitude)
        {
            return "Chicken is at altitude " + altitude + " and is flying at " + Speed + " mph";
        }
    }
}
