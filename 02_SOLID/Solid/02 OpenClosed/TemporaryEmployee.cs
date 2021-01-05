namespace Solid._02_OpenClosed
{
    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee(int id, string name, string type) : base(id, name, type)
        {
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }
}
