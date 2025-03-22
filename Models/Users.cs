using System.ComponentModel.DataAnnotations;

namespace Hotel_Reservations_Manager.Models
{
    public class Users
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string EGN { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public DateTime HireDate { get; set; }

        public bool IsActive { get; set; }

        public DateTime? ReleaseDate { get; set; }

        [Required]
        public Enums.RoleType Role { get; set; }
    }
}
