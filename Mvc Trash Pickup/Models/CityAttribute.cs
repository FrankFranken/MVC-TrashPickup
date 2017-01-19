using System;

namespace Mvc_Trash_Pickup.Models
{
    internal class CityAttribute : Attribute
    {
        public int Id { get; set; }

        public string CityName { get; set; }
    }

}