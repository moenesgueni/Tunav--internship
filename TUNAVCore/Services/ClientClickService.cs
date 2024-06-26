using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUNAVCore.Domain;
using TUNAVCore.Interfaces;

namespace TUNAVCore.Services
{
    public class ClientClickService : Service<ClientClick>, IClientClick
    {
        public ClientClickService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
