using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Reservations_Manager.Models
{
    public class Reservations
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Room")]
        public int RoomId { get; set; }
        public Rooms Room { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public Users User { get; set; }

        public List<Clients> Clients { get; set; } = new List<Clients>();

        [Required]
        public DateTime CheckInDate { get; set; }

        [Required]
        public DateTime CheckOutDate { get; set; }

        [Required]
        public bool IncludesBreakfast { get; set; }

        [Required]
        public bool IsAllInclusive { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

    }
}
