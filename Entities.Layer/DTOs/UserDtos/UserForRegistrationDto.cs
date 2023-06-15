using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.UserDtos
{
    public record UserForRegistrationDto
    {
        [Required(ErrorMessage = "Firstname is required")]
        public String FirstName { get; init; }

        [Required(ErrorMessage = "LastName is required")]
        public String LastName { get; init; }

        [Required(ErrorMessage = "UserName is required")]
        public String UserName { get; init; }

        [Required(ErrorMessage = "Email is required")]
        public String Email { get; init; }

        [Required(ErrorMessage = "Password is required")]
        public String Password { get; init; }

        [Required(ErrorMessage = "PhoneNumber is required")]
        public String PhoneNumber { get; init; }
    }
}
