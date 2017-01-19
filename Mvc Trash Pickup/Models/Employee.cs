using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_Trash_Pickup.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public int ZipcodeTerritoryId { get; set; }

        public IEnumerable<Customer> CustomerList { get; set; }
    }
}