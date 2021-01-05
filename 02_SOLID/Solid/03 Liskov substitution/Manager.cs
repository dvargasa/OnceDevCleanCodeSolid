﻿using System;

namespace Solid._3_LSP.Example2.Solution
{
    class Manager : Employee, IManager
    {
        public override void CalcularePerHourRate(int rank)
        {
            decimal baseAmount = 19.75M;

            Salary = baseAmount + (rank * 4);
        }

        public void GeneratePerformanceReview() => Console.WriteLine("I'm reviewing a direct report's performance.");
    }
}
