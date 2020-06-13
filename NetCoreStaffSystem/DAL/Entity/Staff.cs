using DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace DAL.Entity
{
    public class Staff:CoreEntity
    {
        public string IdentificationNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime HireDate { get; set; }
        public string Title { get; set; }
       
    }
}
