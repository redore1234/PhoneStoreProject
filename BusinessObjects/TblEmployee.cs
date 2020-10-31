using System;

namespace BusinessObjects
{
    public class TblEmployee : BusinessObject
    {
        // ** Enterprise Design Pattern: Identity field pattern

        public string EmployeeID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int RoleID { get; set; }

        // ** Enterprise Design Pattern: Foreign Key Mapping. TblRole is the parent
        public TblRole TblRole { get; set; }

    }
}