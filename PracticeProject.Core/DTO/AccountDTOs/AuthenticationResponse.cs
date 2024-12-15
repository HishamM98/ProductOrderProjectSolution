using PracticeProject.Core.Domain.IdentityEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.DTO.AccountDTOs
{
    public class AuthenticationResponse
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Token { get; set; }
        public DateTime Expiration { get; set; }
        public string? RefreshToken { get; set; } = string.Empty;
        public DateTime RefreshTokenExpirationDateTime { get; set; }
    }

    public static class UserExtensions
    {
        public static AuthenticationResponse ToAuthResponse(this User user)
        {
            return new AuthenticationResponse
            {
                FullName = user.FullName,
                Email = user.Email,
                Address = user.Address,
                RefreshToken = user.RefreshToken,
                RefreshTokenExpirationDateTime = user.RefreshTokenExpirationDateTime
            };
        }
    }
}
