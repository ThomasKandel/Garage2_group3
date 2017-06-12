using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Garage2.Models;
using System.Data.Entity;
namespace Garage2.DataAccess
{
    public class ParkingContext : DbContext
    {
        public ParkingContext() : base("name=ParkingContext")
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}