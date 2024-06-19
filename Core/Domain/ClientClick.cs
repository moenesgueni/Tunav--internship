using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;




namespace Core.Domain
{
    public class ClientClick
    {
        [Key]
        public int ClientClickId { get; set; }

        public virtual Compte Compte { get; set; }
        public int CompteId { get; set; }

        public virtual Client Client { get; set; }
        public int ClientId { get; set; }

        public DateTime date_dernier_cnx { get; set; }
    }
}
