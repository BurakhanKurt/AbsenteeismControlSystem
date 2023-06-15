using System.Security.Claims;

namespace Service.Concretes
{
    public class TokenHelper 
    {
        public static int GetUserIdFromToken(ClaimsPrincipal? context)
        {
            var id = Convert.ToInt32(
                context.
                Claims.
                FirstOrDefault(d => d.Type == "key").Value
            );
            return id;
        }
    }
}
