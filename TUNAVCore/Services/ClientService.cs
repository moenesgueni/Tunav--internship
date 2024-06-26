using TUNAVCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUNAV.Core.Domain;
using TUNAVCore.Interfaces;

namespace TUNAVCore.Services
{
    public class ClientService : Service<Client>, IClientService
    {
        public List<Client> Clients { get; set; } = new List<Client>();

        public ClientService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }


        public int ClientsNb()
        {
            return Clients.Count();
        }

        public IEnumerable<Client> GetClients(int n)
        {
            return GetMany().OrderByDescending(x => x.ClientId).Take(n);
        }

        public IEnumerable<Compte> GetComptes(Client client)
        {
            return client.Comptes;
        }



    }
}
