using System;
using System.Collections.Generic;

namespace Hotels.Models
{
    public partial class Favorites
    {
        public int FavoriteId { get; set; }
        public DateTime DateCreated { get; set; }
        public int Status { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }
    }
}
