using System.ComponentModel.DataAnnotations;

namespace Hotel_Reservations_Manager.Models
{
    public class Rooms
    {
        public int Id { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public Enums.RoomType Type { get; set; }

        public bool IsAvailable { get; set; } = true;

        [Required]
        public decimal PricePerAdult { get; set; }

        [Required]
        public decimal PricePerChild { get; set; }

        [Required]
        public int RoomNumber { get; set; }
    }
}
