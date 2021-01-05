namespace SOLID._02_OpenClosed
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string EmployeeType { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name, string type)
        {
            ID = id;
            Name = name;
            EmployeeType = type;
        }

        public abstract decimal CalculateBonus(decimal salary);       
    }
}