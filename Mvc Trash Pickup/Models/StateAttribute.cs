using System;

namespace Mvc_Trash_Pickup.Models
{
    internal class StateAttribute : Attribute
    {
        public int Id { get; set; }

        public string StateName { get; set; }
    }

}