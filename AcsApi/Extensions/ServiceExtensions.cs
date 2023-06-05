using Microsoft.EntityFrameworkCore;
using Repositories.Layer;
using Repositories.Layer.Repositories.Abstracts;
using Repositories.Layer.Repositories.Concretes;

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
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ICourseDetailRepository, CourseDetailRepository>();
            services.AddScoped<ICourseCalendarRepository, CourseCalendarRepository>();
        }
    }
}
