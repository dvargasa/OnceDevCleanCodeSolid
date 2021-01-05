using Solid.DIP.Example1.Solution.Interfaces;

namespace Solid.DIP.Example1.Solution
{
    public class ClientService : IClientServices
    {
        private readonly IClientRepository _clientRepository;
        private readonly IEmailServices _emailServices;

        public ClientService(IClientRepository clientRepository, IEmailServices emailServices)
        {
            _clientRepository = clientRepository;
            _emailServices = emailServices;
        }

        public string AddClient(Client client)
        {
            if (!client.IsValid())
                return "Invalid data";
                        
            _clientRepository.AddClient(client);
                       
            _emailServices.Send("asdas@x.com", client.Email, "Welcome", "Congratulations!!!");

            return "Client ok";
        }
    }
}
