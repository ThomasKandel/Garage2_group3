using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Foolproof;

using System.Linq;
using System.Web;

namespace Garage2.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        [Required]
        [Remote("IsVehicleParked", "Vehicles", ErrorMessage = "The Vehicle with same registration is already parked and active now")]
        [DisplayName("Registration number")]
        [RegularExpression(@"^[A-Z]{3}[0-9]{3}$", ErrorMessage = "Must be three capital letters followed by three digits")]
        public string RegNum { get; set; }
        [Required]
        public VehicleType Type { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Color { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Brand { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Model { get; set; }
        [Required]
 //       [Remote("HasWheels", "Vehicles", ErrorMessage = "The Vehicle suppose to has number more than zero")]
        public int Wheels { get; set; }
        public DateTime CheckInTime { get; set; }
        public Nullable<DateTime> CheckOutTime { get; set; }
    }
}