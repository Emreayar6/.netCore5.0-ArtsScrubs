using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public string ClientAddress { get; set; }
        public string ClientGSM { get; set; }
        public string ClientMail { get; set; }
        public string ClientPassword { get; set; }
        public string ClientOrder { get; set; }
        public bool ClientStatus { get; set; }
    }
}
