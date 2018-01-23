using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
 

namespace DAL.Models
{
    public class GameIDs
    {
        [Key]
        public string iGameID { get; set; }

        public string iTeamIDA { get; set; }

        public string iTeamIDB { get; set; }

        public string strGameName { get; set; }

        public string dtGameDate { get; set; }
    }
}
