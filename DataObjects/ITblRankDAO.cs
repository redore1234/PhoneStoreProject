using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public interface ITblRankDAO
    {
        //get RankID by name
        int GetRankIDByName(string RankName);
    }
}
