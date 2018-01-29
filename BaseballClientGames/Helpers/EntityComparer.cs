using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballClientGames.Helpers
{
    public class EntityComparer : IEqualityComparer<GameIDs>
    {
        public bool Equals(GameIDs x, GameIDs y)
        {
            return x.iGameID == y.iGameID;
        }


        public int GetHashCode(GameIDs obj)
        {
            return 0;
        }
    }
}
