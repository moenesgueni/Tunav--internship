using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Compte> Comptes { get; set; }
        public override string ToString()
        {
           return "Client_Id =" + ClientId + "Name =" + Name + "]";
           
        }
    }
}
