using System.ComponentModel.DataAnnotations;

namespace crud_web_app.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public required string Name { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Phone]
        public required string PhoneNumber { get; set; }

        public required string Address { get; set; }
    }
}
