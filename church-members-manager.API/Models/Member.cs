using System.ComponentModel.DataAnnotations;

namespace church_members_manager.API.Models
{
    public class Member
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public required string Names { get; set; }

        [Required]
        [MaxLength(50)]
        public required string LastNames { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public required string Role { get; set; }
        public required string Minister { get; set; }
        public required string Address { get; set; }
        public required bool Baptized { get; set; }
    }
}
