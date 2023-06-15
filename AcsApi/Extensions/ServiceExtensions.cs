
using Entities.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Repositories;
using Repositories.Repositories.Abstracts;
using Repositories.Repositories.Concretes;
using Repositories.UnıtOfWorks.Abstract;
using Repositories.UnıtOfWorks.Concrate;
using Service.Abstracts;
using Service.Concretes;
using System.Text;

namespace AcsApi.Extensions
{
    public static class ServiceExtensions
    {

        public static void ConfigureSqlContext(this IServiceCollection services,
            IConfiguration configuration) =>
                services.AddDbContext<AppDbContext>(options =>
                    options
                    .UseSqlServer(configuration.GetConnectionString("sqlConnection"))
                );

        public static void RegisterRepositories(this IServiceCollection services)
        {

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ICourseDetailRepository, CourseDetailRepository>();
            services.AddScoped<ICourseCalendarRepository, CourseCalendarRepository>();
            services.AddScoped<ISyllabusRepository, SyllabusRepository>();
        }

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<ICourseService, CourseManager>();
            services.AddScoped<ICourseDetailService, CourseDetailManager>();
            services.AddScoped<ICourseCalendarService, CourseCalenderManager>();
            services.AddScoped<ISyllabusService, SyllabusManager>();
            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IAuthenticationService, AuthenticationManager>();
        }

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentity<User, IdentityRole<int>>(opt =>
            {
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireDigit = true;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequiredLength = 8;

                opt.User.RequireUniqueEmail = true;
            })
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();
        }

        public static void ConfigureJWT(this IServiceCollection services,
            IConfiguration configuration)
        {
            var jwtSettings = configuration.GetSection("JwtSettings");
            var secretKey = jwtSettings["secretKey"];

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = jwtSettings["validIssuer"],
                ValidAudience = jwtSettings["validAudience"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
            };

            services.AddSingleton(tokenValidationParameters);

            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
                    options.TokenValidationParameters = tokenValidationParameters
                );
            
        }
    }
}
