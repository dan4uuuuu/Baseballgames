using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
 

namespace DAL.Models
{
    public class ClientNonClientGames
    {
        [Key]
        public string NonClientID { get; set; }

        public string NonClientName { get; set; }

        public string  ClientName { get; set; }

        public string GameDate { get; set; }
    }
}
