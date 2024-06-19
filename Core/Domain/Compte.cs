using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;



namespace Core.Domain
{
    public class Compte
    {
        [Key]
        public int CompteId { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public DateTime date_dernier_cnx { get; set; }
        public string lien { get; set; }

        public virtual Client Client{ get; set; }
        [ForeignKey("Client")]
        public int ClientFk { get; set; }

        public virtual ICollection<ClientClick> ClientClicks { get; set; }

        public override string ToString()
        {
            return "Compte_Id =" + CompteId + "Login =" + login + "Password=" + password + "Date_Dernier_Cnx =" + date_dernier_cnx + "Lien =" + lien + "]";
        }

    }
}
