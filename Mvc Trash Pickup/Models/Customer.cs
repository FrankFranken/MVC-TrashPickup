using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_Trash_Pickup.Models
{
    public class Customer
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StreetOne { get; set; }

        public string StreetTwo { get; set; }

        //public CityAttribute City { get; set; }

        //public int CityId { get; set; }

        //public StateAttribute State { get; set; }

        //public int StateId { get; set; }

        //public ZipcodeAttribute Zipcode { get; set; }

        public int ZipcodeId { get; set; }

        public string EMailAddress { get; set; }

        public bool IsCurrentCustomer { get; set; }

        public PickUp DayOfWeekPickUp { get; set; }

        public int DayOfWeekPickUpId { get; set; }

        public UserType UserType { get; set; }

        public int UserTypeId { get; set; }

      


    }
}
