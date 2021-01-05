using System;

namespace Solid._3_LSP.Example2.Solution
{
    static class ExecuteSample
    {
        public static void Execute()
        {
            IManager accountingVP = new Ceo();
            accountingVP.FirstName = "John";
            accountingVP.LastName = "Nash";
            accountingVP.CalcularePerHourRate(4);

            IManaged emp = new Manager();           
            emp.FirstName = "Mick";
            emp.LastName = "Jagger";
            emp.AssignManager(accountingVP); 
            emp.CalcularePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is {emp.Salary}/hour.");
        }
    }
}
