using AutoMapper;
using Entities.DTOs.UserDtos;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Service.Abstracts;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Service.Concretes
{
    public class AuthenticationManager : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private User? _user;
        public AuthenticationManager(
            UserManager<User> userManager,
            IConfiguration configuration,
            IMapper mapper)
        {
            _userManager=userManager;
            _configuration=configuration;
            _mapper=mapper;
        }


        public async Task<IdentityResult> RegisterUserAsync(UserForRegistrationDto userForRegistrationDto)
        {
            var user = _mapper.Map<User>(userForRegistrationDto);
            user.CreatedDate = DateTime.Now;
            user.isActive = false;
            var result = await _userManager
                .CreateAsync(user,userForRegistrationDto.Password);

            return result;
        }

        public async Task<bool> ValidateUserAsync(UserForAuthenticationDto userForAuthDto)
        {
            _user = await  _userManager.FindByNameAsync(userForAuthDto.UserName);

            var result = (_user is not null &&
                await _userManager.CheckPasswordAsync(_user,userForAuthDto.Password));

            return result;
        }
        public string CreateToken()
        {
            var signinCredentials = GetSigninCredentials();
            var claims = GetClaims();
            var tokenOptions = GenerateTokenOptions(signinCredentials,claims);

            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }
         
        private SigningCredentials GetSigninCredentials()
        {
            var jwtSetting = _configuration.GetSection("JwtSettings");
            var key = Encoding.UTF8.GetBytes(jwtSetting["secretKey"]);
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signinCredentials,
            List<Claim> claims)
        {
            var jwtSetting = _configuration.GetSection("JwtSettings");

            var tokenOptions = new JwtSecurityToken(
                    issuer: jwtSetting["validIssuer"],
                    audience: jwtSetting["validAudience"],
                    claims: claims,
                    expires: DateTime.Now.AddYears(Convert.ToInt32(jwtSetting["expires"])),
                    signingCredentials: signinCredentials);

            return tokenOptions;
        }

        private List<Claim> GetClaims()
        {
            var list = new List<Claim>()
            {
                new Claim("key",_user.Id.ToString())
            };

            return list;
        }
    }
}
