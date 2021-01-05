using SOLID._02_OpenClosed;

namespace Solid._02_OpenClosed
{
    public class InternEmployee : Employee
    {
        public InternEmployee(int id, string name, string type) : base(id, name, type)
        {
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .01M;
        }
    }
}
