using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_Trash_Pickup.Models
{
    public class UserType
    {
        public int Id { get; set; }

        public string MemberName { get; set; }

        public double PickUpRate { get; set; }

        public double PickUpRoutes { get; set; }
    }
}
