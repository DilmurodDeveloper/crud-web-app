using System.ComponentModel.DataAnnotations;

namespace crud_web_app.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public required string Email { get; set; }

        [Phone(ErrorMessage = "Invalid Phone Number")]
        public required string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public required string Address { get; set; }
    }
}
