using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations.Schema;

namespace UserProfile.Common.Modals
{
    [Table("UserDetails")]
=======

namespace UserProfile.Common.Modals
{
>>>>>>> origin/master
    public class UserModel
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
<<<<<<< HEAD
        public string LoginId { get; set; } = string.Empty;
=======
        public string Username { get; set; } = string.Empty;
>>>>>>> origin/master

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string FullName { get; set; } = string.Empty;
<<<<<<< HEAD

        // One-to-one navigation
        public required LoginModel Credentials { get; set; }
    }

    [Table("UserCred")]
    public class LoginModel
    {
        [Key]
        [ForeignKey("User")]   // PK = FK
        public int Id { get; set; }

        public string Password { get; set; } = string.Empty;

        // Navigation
        public UserModel User { get; set; } = null!;
    }

=======
    }
>>>>>>> origin/master
}