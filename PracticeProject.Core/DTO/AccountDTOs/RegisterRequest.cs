using PracticeProject.Core.Domain.IdentityEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.DTO.AccountDTOs
{
    public class RegisterRequest
    {
        [Required]
        public string FullName { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        [MinLength(10)]
        public string Password { get; set; } = string.Empty;
        [Required]
        [MinLength(10)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;
        [Required]
        [MinLength(5)]
        public string Address { get; set; } = string.Empty;

        public User ToUser()
        {
            return new User
            {
                FullName = FullName,
                UserName = Email,
                Email = Email,
                Address = Address
            };
        }
    }
}
