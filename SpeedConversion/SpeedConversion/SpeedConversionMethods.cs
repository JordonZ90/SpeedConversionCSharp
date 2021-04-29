using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedConversion
{
    public class SpeedConversionMethods
    {
        public static double MphToKph(double mph)
        {
            double kph = mph * 1.609344;
            return kph;
        }
        public static double KphToMph(double kph)
        {
            double mph = kph / 1.609344;
            return mph;
        }
    }
}
