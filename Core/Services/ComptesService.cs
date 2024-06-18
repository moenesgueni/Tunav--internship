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
    public class ComptesService : Service<Compte>, ICompteService
    {
        public ComptesService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public int ComptesNb()
        {
            throw new NotImplementedException();
        }
    }
}
