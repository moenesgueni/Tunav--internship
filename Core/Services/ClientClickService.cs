using Core.Domain;
using Core.Interfaces;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{
    public class ClientClickService : Service<ClientClick>
    {
        public ClientClickService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
