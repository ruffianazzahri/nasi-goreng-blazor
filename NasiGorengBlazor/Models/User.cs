using System.ComponentModel.DataAnnotations;

namespace NasiGorengBlazor.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Username { get; set; } = string.Empty;

        [Required, StringLength(255)]
        public string Email { get; set; } = string.Empty;

        [Required, StringLength(255)]
        public string PasswordHash { get; set; } = string.Empty;
    }
}
