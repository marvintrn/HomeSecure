using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace HomeSecure.Models
{
    public class HomeSecureContext : DbContext
    {
        public DbSet<Detector> Detectors { get; set; }
        public DbSet<Move> Moves { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
