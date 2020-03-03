using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotels.Models
{
    public class SearchFiltersModel
    {
        public  int[] CountOfGuests { get; set; }
        public string[] Cities { get; set; }
        public Tuple<int, string>[] RoomTypes { get; set; }
    }
}
