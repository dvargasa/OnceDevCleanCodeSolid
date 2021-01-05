using System;

namespace CSharp_Basics.V7
{
    public class Tuples    
    {
        void OldVersion()
        {
            Tuple<string,string> namedLetters = new Tuple<string, string>("a","b");
            Console.WriteLine($"{namedLetters.Item1}, {namedLetters.Item2}");
        }
        void Demo()
        {
            (string Alpha, string Beta) namedLetters = ("a", "b");
            Console.WriteLine($"{namedLetters.Alpha}, {namedLetters.Beta}");

            var alphabetStart = (Alpha: "a", Beta: "b");
            Console.WriteLine($"{alphabetStart.Alpha}, {alphabetStart.Beta}");
        }        
    }
}