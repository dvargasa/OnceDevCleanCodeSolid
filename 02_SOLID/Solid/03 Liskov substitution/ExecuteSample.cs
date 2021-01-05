using System;

namespace Solid._3_LSP.Example2.Violation
{
    static class ExecuteSample
    {
        public static void Execute()
        {
            Manager accountingVP = new Manager();
            accountingVP.FirstName = "John";
            accountingVP.LastName = "Nash";
            accountingVP.CalcularePerHourRate(4);

            Employee emp = new Ceo();
            emp.FirstName = "Mick";
            emp.LastName = "Jagger";
            emp.AssignManager(accountingVP);
            emp.CalcularePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is {emp.Salary}/hour.");
        }
    }
}
