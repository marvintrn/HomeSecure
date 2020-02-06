using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeSecure.Models
{
    public class Detector
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public long RoomId { get; set; }
        public virtual Room Room { get; set; }

        public virtual List<Move> Moves { get; set; }
    }
}
