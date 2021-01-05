namespace CSharp_Basics.V9
{
    public record Person
    {
        public string LastName { get; }
        public string FirstName { get; }

        public Person(string first, string last) =>
            (FirstName, LastName) = (first, last);
    }

    public record Teacher : Person
    {
        public string Subject { get; }

        public Teacher(string first, string last, string sub)
            : base(first, last) => Subject = sub;
    }
}