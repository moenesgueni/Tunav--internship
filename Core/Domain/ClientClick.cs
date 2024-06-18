using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class ClientClick
    {
        [Key]
        public int ClientClickId { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int CompteId { get; set; }
        public Compte Compte { get; set; }
        public DateTime ClickedAt { get; set; }
    }
}
