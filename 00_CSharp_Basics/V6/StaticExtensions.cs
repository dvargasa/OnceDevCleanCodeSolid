using System;
using static System.Linq.Enumerable;
using static System.String;

namespace CSharp_Basics.V6
{
    static class StaticExtensions
    {   
        static void Demo()
        {
            var values = new int[] { 1, 2, 3, 4 };
            var evenValues = values.Where (i => i % 2 == 0);
            System.Console.WriteLine (Join(",", evenValues));
        }     

        //nameof Expressions
        static void NameOf()
        {
            throw new ArgumentException("Problem with " + nameof(StaticExtensions));
        }
    }
}