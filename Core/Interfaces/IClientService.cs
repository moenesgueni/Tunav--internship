using Core.Domain;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IClientService:IService<Client>
    {
        public int ClientsNb();
        IEnumerable<Client> GetClients(int n);
        IEnumerable<Compte> GetComptes(Client client);
    }
}
