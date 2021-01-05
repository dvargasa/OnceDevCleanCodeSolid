using System;

namespace CSharp_Basics.V6
{
    public class AutoPropertyInitialization
    {
        public DateTime Due { get; set; } = DateTime.Now.AddDays(1);
        public DateTime Created { get; } = DateTime.Now;
        public string Description { get; }

        public AutoPropertyInitialization(string description)
        {
            this.Description = description;
        }

        void Demo()
        {
            this.Description = "Test";
        }
    }
}