// using Microsoft.EntityFrameworkCore;
// using SpaceTraders.Client.Models;
// using SpaceTraders.Client.Systems.Item;
// using System;
// using System.Collections.Generic;

// public class ShipContext : DbContext
// {
//     public DbSet<Ship> Ships { get; set; }

//     public string DbPath { get; }

//     public ShipContext()
//     {
//         var folder = Environment.SpecialFolder.LocalApplicationData;
//         var path = Environment.GetFolderPath(folder);
//         DbPath = Path.Join(path, "spaceTraders.db");
//     }

//     // The following configures EF to create a Sqlite database file in the
//     // special "local" folder for your platform.
//     protected override void OnConfiguring(DbContextOptionsBuilder options)
//         => options.UseSqlite($"Data Source={DbPath}");
// }

// public class Ship
// {
//     public string Symbol { get; set; }
//     public ShipRegistration Registration { get; set; }
//     public ShipNav Nav { get; set; }

// }

// public class ShipRegistration
// {
//     public string Name { get; set; }
//     public string FactionSymbol { get; set; }
//     public string Role { get; set; }
// }

// public class ShipNav
// {
//     public string description { get; set; }
//     public string SystemSymbol { get; set; }
//     public string WaypointSymbol { get; set; }
//     public ShipNavRoute MyProperty { get; set; }
// }

