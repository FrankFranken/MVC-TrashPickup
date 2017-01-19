using System;

namespace Mvc_Trash_Pickup.Models
{
    internal class ZipcodeAttribute : Attribute
    {
        public int Id { get; set; }

        public string ZipcodeNum { get; set; }

    }

}