using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class TblCustomer : BusinessObject
    {
        // ** Enterprise Design Pattern: Identity field pattern
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public long SpentMoney { get; set; }
        public int Point { get; set; }
        public string RankID { get; set; }
        public string StatusID { get; set; }

        // ** Enterprise Design Pattern: Foreign Key Mapping. TblRank, TblStatus are the parents
        public TblRank TblRank { get; set; }
        public TblStatus TblStatus { get; set; }
    }
}
