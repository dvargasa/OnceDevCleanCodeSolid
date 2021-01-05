﻿namespace Solid.DIP.Example1.Violation
{
    public class ClientService
    {
        public string AddClient(Client client)
        {
            if (!client.IsValid())
                return "Invalid data";
                        
            var repo = new ClientRepository();
            repo.AddClient(client);

            EmailServices.Send("asdas@x.com", client.Email, "Welcome", "Congratulations!!!");

            return "Client ok";
        }
    }
}
