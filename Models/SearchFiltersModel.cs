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
        public int[] RoomId { get; set; }
        public string[] Name { get; set; }
        public string[] Area { get; set; }
        public string[] Photo { get; set; }
        public int[] Price { get; set; }
        public string[] Location { get; set; }
        public string[] LatLocation { get; set; }
        public string[] LngLocation { get; set; }
        public string[] ShortDescription { get; set; }
        public string[] LongDescription { get; set; }
        public int[] Parking { get; set; }
        public int[] Wifi { get; set; }
        public int[] PetFriendly { get; set; }
    }
}
