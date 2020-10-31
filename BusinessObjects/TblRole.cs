using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class TblRole : BusinessObject
    {
        // ** Enterprise Design Pattern: Identity field pattern

        public int RoleID { get; set; }

        public string RoleName { get; set; }
    }
}
