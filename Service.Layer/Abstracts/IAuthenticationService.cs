
using Entities.DTOs.UserDtos;
using Microsoft.AspNetCore.Identity;

namespace Service.Abstracts
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistrationDto); 
    }
}
