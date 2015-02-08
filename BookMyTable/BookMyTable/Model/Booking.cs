using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyTable.Model
{
    class Booking
    {
        string UserID { get; set; }
        List<Table> Tables { get; set; }
        string BookingTime { get; set; }
    }
}
