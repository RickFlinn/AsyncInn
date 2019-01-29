using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data
{
    public class AsyncInnDbContext : DbContext
    {
        public AsyncInnDbContext(DbContextOptions<AsyncInnDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Composite Keys
            modelBuilder.Entity<RoomAmenity>().HasKey(ra => new { ra.RoomID, ra.AmenityID });
            modelBuilder.Entity<HotelRoom>().HasKey(room => new { room.HotelLocationID, room.RoomNumber });

            // Seed data
            modelBuilder.Entity<HotelLocation>().HasData( new { ID = 1, Name = "Charleston", Address = "123 Nonexistington Street", Phone = "885-900-1337" },
                                                          new { ID = 2, Name = "Ponk Place", Address = "Downtownish", Phone = "206-299-9000" },
                                                          new { ID = 3, Name = "Emerald City AsyncInn", Address = "Somewhere Over the Rainbow", Phone = "Tap the ruby slippers three times" },
                                                          new { ID = 4, Name = "Amazon-syncInn", Address = "Greater Downtown Amazon", Phone = "206-574-7699" },
                                                          new { ID = 5, Name = "The Molemensville Async", Address = "Deep, deep, deep underground", Phone = "1-800-DIG-DEEP" }
                                                         );

            modelBuilder.Entity<Room>().HasData( new { ID = 1, Name = "Teeny, Tiny, Trashable", Layouts.Studio },
                                                 new { ID = 2, Name = "School Field Trip Suite", Layouts.Two },
                                                 new { ID = 3, Name = "The Seedy Motel Experience", Layouts.One },
                                                 new { ID = 4, Name = "Loosely Typed Relaxation Getaway", Layouts.One },
                                                 new { ID = 5, Name = "Homely Tuscan Countryside Peasant Farmhouse Studio", Layouts.Studio },
                                                 new { ID = 6, Name = "All Out Of Ideas Layout", Layouts.One }
                                                );

            modelBuilder.Entity<Amenity>().HasData( new { ID = 1, Name = "Coffee Manufacturing Unit" },
                                                    new { ID = 2, Name = "Gnome Butler" },
                                                    new { ID = 3, Name = "Flea-Free Bedding" },
                                                    new { ID = 4, Name = "Wall-Mounted Cookie Dispenser" },
                                                    new { ID = 5, Name = "Pull-Out Hot Tub" },
                                                    new { ID = 6, Name = "Guy With Giant Gong Alarm Clock" }
                                                  );

        }

        // Tables

        public DbSet<HotelLocation> HotelLocations { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomAmenity> RoomAmenities { get; set; }
    }
}
