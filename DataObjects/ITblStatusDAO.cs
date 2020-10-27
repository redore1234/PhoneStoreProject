using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public interface ITblStatusDAO
    {
        //get StatusID by StatusName
        int GetStatusIDByStatus(string StatusName);
    }
}
