using TUNAVCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUNAV.Core.Domain;

namespace TUNAVCore.Interfaces
{
    public interface IClientService : IService<Client>
    {
        public int ClientsNb();
        public IEnumerable<Client> GetClients(int n);
        public IEnumerable<Compte> GetComptes(Client client);
    }
}
