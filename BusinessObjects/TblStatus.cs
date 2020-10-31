using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class TblStatus : BusinessObject
    {
        public int StatusID { get; set; }
        public string Status { get; set; }
    }
}
