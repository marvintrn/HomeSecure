using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeSecure.Models
{
    public class Move
    {
        [Key]
        public long Id { get; set; }
        public DateTime Date { get; set; }

        public long DetectorId { get; set; }
        public virtual Detector Detector { get; set; }
    }
}
