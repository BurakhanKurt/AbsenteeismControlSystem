
using Entities.DTOs.UserDtos;
using Microsoft.AspNetCore.Identity;

namespace Service.Abstracts
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUserAsync(UserForRegistrationDto userForRegistrationDto); 
        Task<bool> ValidateUserAsync(UserForAuthenticationDto userForAuthDto);
        string CreateToken();
    }
}
