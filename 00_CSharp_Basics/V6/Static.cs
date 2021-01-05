using System;
using static System.Math;
namespace CSharp6Features
{
    class MyClassV5
    {
        public static Tuple<double, double> SolarAngleOld(double latitude, double declination, double hourAngle)
        {
            var tmp = Math.Sin(latitude) * Math.Sin(declination) + Math.Cos(latitude) * Math.Cos(declination) * Math.Cos(hourAngle);
            return Tuple.Create(Math.Asin(tmp), Math.Acos(tmp));
        }
    }
    class MyClassV6
    {
        public static Tuple<double, double> SolarAngleNew(double latitude, double declination, double hourAngle)
        {
            var tmp = Asin(latitude) * Sin(declination) + Cos(latitude) * Cos(declination) * Cos(hourAngle);
            return Tuple.Create(Asin(tmp), Acos(tmp));
        }
    }
}