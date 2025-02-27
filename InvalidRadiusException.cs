using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class InvalidRadiusException: Exception
    {
        public InvalidRadiusException(double radius)
        {
            string Message = $"Invalid radius {radius}: must be non-negative";
        }

        public InvalidRadiusException(double radius, double maxRadius)
        {
            string Message = $"Invalid radius {radius}: must be between 0 and {maxRadius}";
        }
    }
}
