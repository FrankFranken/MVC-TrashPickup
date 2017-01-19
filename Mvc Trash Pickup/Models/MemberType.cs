using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_Trash_Pickup.Models
{
    public class MemberType
    {
        public int Id { get; set; }

        public string MemberName { get; set; }

        public double PickUpRate { get; set; }
    }
}