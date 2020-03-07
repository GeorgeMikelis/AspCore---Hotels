using System.ComponentModel.DataAnnotations;

namespace Hotels.Models
{
    public class BookingModel
    {
        [Required]
        public string CheckInDate { get; set; }
        [Required]
        public string CheckOutDate { get; set; }
        [Required]
        public int RoomId { get; set; }
    }
}