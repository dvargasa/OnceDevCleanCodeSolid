namespace Solid._1_SRP.Example1.Solution
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public bool IsValidEmail() => Email.Contains("@");
    }
}
