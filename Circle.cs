using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Circle
    {
        private double Radius { get; set; }
        private const double MAX_RADIUS = 20;

        public Circle(double newRadius)
        {
            if (newRadius < 0)
            {
                //throw exception
            }
            else if (newRadius > MAX_RADIUS)
            {
                // throw exception
            }
            else
            {
                Radius = newRadius;
            }
        }

        public override string ToString()
        {
            return $"Circle[radius={Radius}]";
        }
    }
}
