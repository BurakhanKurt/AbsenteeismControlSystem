using AutoMapper;
using Entities.Layer.DTOs.UserDtos;
using Entities.Layer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Service.Layer.Abstracts;

namespace Service.Layer.Concretes
{
    public class AuthenticationManager : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public AuthenticationManager(
            UserManager<User> userManager,
            IConfiguration configuration,
            IMapper mapper)
        {
            _userManager=userManager;
            _configuration=configuration;
            _mapper=mapper;
        }

        public async Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistrationDto)
        {
            var user = _mapper.Map<User>(userForRegistrationDto);
            user.CreatedDate = DateTime.Now;
            user.isActive = false;
            var result = await _userManager
                .CreateAsync(user,userForRegistrationDto.Password);

            return result;
        }
    }
}
