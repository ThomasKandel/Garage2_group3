using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage2.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string RegNum { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Wheels { get; set; }
        public DateTime CheckInTime { get; set; }
        public Nullable<DateTime> CheckOutTime { get; set; }
    }
}