using Core.Domain;
using Core.Interfaces;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class ClientService : Service<Client>, IClientService
    {
        public ClientService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
