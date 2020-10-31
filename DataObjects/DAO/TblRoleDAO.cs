using BusinessObjects;
using DataObjects.AdoNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.DAO
{
    public class TblRoleDAO : ITblRoleDAO
    {
        static Db db = new Db();

        //Get RoleName by RoleID
        public TblRole GetRoleByRoleID(int RoleID)
        {
            string StoreProcedure = "spGetRole";
            object[] parms = { "@RoleID", RoleID };
            return db.Read(StoreProcedure, Make, parms).FirstOrDefault();
        }

        // Return RoleName based on DataReader
        static Func<IDataReader, TblRole> Make = reader => 
        new TblRole
        {
            RoleName = reader["RoleName"].ToString()
        };
    }
}
