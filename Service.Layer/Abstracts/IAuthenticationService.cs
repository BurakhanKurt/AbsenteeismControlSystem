
using Entities.Layer.DTOs.UserDtos;
using Microsoft.AspNetCore.Identity;

namespace Service.Layer.Abstracts
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistrationDto); 
    }
}
