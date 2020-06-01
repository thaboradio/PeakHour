using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace PeakHour.Models
{
    public class MPeakHour
    {
        public int Id { get; set; }
        public DateTime Day { get; set; }
        public string Session { get; set; }
        public string Mood { get; set; }
    }
}
