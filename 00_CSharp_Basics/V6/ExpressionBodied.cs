using System;

namespace CSharp_Basics.V6
{
    public class ExpressionBodied
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString() => $"{FirstName} {LastName}";
        // public override string ToString()
        // {
        //     return string.Format("{0} {1}", FirstName, LastName);
        // }


        public void Log(string message) => 
        System.Console.WriteLine($"{DateTime.Now.ToString("s", System.Globalization.CultureInfo.InvariantCulture )}: {message}");
    }
}