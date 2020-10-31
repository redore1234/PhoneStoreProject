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
        Db db = new Db();

        //Get RoleName by RoleID
        public TblRole GetRoleByRoleID(int RoleID)
        {
            //string StoreProcedure = "spGetRoleName";
            string StoreProcedure = "SELECT * FROM tblRole WHERE RoleID=@RoleID";
            object[] parms = { "@RoleID", RoleID };
            return db.Read(StoreProcedure, Make, parms).FirstOrDefault();
        }

        // Return RoleName based on DataReader
        static Func<IDataReader, TblRole> Make = reader => 
        new TblRole
        {
            RoleID = int.Parse(reader["RoleID"].ToString()),
            RoleName = reader["RoleName"].ToString()
        };
    }
}
