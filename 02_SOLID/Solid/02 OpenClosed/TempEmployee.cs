using SOLID._02_OpenClosed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._02_OpenClosed
{
    public class TempEmployee : Employee
    {
        public TempEmployee(int id, string name, string type) : base(id, name, type)
        {
        }

        public override decimal CalculateBonus(decimal salary)
        {
            throw new NotImplementedException();
        }
    }
}
