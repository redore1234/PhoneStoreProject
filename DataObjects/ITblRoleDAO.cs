using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public interface ITblRoleDAO
    {
        //get RoleID by Name
        int GetRoleIDByRole(string RoleName);
    }
}
