namespace Solid.DIP.Example1.Violation
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
                
        public bool IsValid() => EmailServices.IsValid(Email);
    }
}
