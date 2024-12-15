using PracticeProject.Core.Domain.IdentityEntities;
using PracticeProject.Core.DTO.AccountDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.ServiceContracts
{

    public interface IJwtService
    {
        AuthenticationResponse CreateJwtToken(User user);
        ClaimsPrincipal? GetPrincipalFromJwtToken(string? token);
    }
}
