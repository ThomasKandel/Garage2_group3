namespace Garage2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Garage2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Garage2.DataAccess.ParkingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Garage2.DataAccess.ParkingContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Vehicles.AddOrUpdate(
                p => p.RegNum,
                new Vehicle { RegNum = "WEB 214", Type = global::VehicleType.Car, Color = "Silver", Brand = "TOYOTA", Model = "2005", Wheels = 4, CheckInTime = DateTime.Now, CheckOutTime = DateTime.Now },
                new Vehicle { RegNum = "OMM 455", Type = global::VehicleType.Boat, Color = "Silver", Brand = "Volvo", Model = "2017", Wheels = 4, CheckInTime = DateTime.Now,  CheckOutTime = DateTime.Now }

                );
        }
    }
}
