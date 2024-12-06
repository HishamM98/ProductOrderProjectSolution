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
        public string? FullName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [MinLength(10)]
        public string? Password { get; set; }
        [Required]
        [MinLength(10)]
        [Compare("Password")]
        public string? ConfirmPassword { get; set; }

    }
}
