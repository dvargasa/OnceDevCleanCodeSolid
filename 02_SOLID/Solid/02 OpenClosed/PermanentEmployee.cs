namespace Solid._02_OpenClosed
{
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee(int id, string name, string type) : base(id, name, type)
        {
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }
}
