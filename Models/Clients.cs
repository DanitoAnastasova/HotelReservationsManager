using System.ComponentModel.DataAnnotations;

namespace Hotel_Reservations_Manager.Models
{
    public class Clients
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public bool IsAdult { get; set; }


    }
}
