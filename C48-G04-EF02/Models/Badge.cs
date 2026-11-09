using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C48_G04_EF02.Models
{


    public class Badge
    {
        public int Id { get; set; }
        public string BadgeNumber { get; set; } = string.Empty;
        public DateTime IssuedDate { get; set; }

        public string Tier { get; set; } = string.Empty;

        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; } = null!;
    }
}
