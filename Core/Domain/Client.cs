using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Core.Domain
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Compte> Comptes { get; set; }

        public virtual  ICollection<ClientClick> ClientClicks { get; set; }

        public override string ToString()
        {
           return "Client_Id =" + ClientId + "Name =" + Name + "]";
           
        }
    }
}
