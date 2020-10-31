using BusinessObjects;
using DataObjects.AdoNet;
using System;
using System.Data;
using System.Linq;

namespace DataObjects.DAO
{
    class TblRankDAO : ITblRankDAO
    {
        static Db db = new Db();
       
        // creates a TblRank object based on DataReader
        static Func<IDataReader, TblRank> Make = reader =>
        new TblRank
        {
            RankName = reader["rankName"].ToString()
        };

        public TblRank GetRankByRankID(int RankID)
        {
            string StoreProc = "spGetRank";
            object[] parms = { "@RankID", RankID };
            return db.Read(StoreProc, Make, parms).FirstOrDefault();
        }
    }
}
