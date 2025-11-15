using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Token.Common.Modals
{
    [Table("UserCred")]
    public class LoginModel
    {
        [Key]
        public required string LoginId { get; set; }
        [MinLength(6)]
        public required string Password { get; set; }
    }
}
