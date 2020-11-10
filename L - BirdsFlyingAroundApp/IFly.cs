using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L___BirdsFlyingAroundApp
{
    interface IFly
    {
        public string Fly();
        public string SetLocation();
        public string SetAltitude(double altitude);
    }
}
