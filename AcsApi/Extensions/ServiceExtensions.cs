using Microsoft.EntityFrameworkCore;
using Repositories.Layer;
using Repositories.Layer.Repositories.Abstracts;
using Repositories.Layer.Repositories.Concretes;
using Repositories.Layer.UnıtOfWorks.Abstract;
using Repositories.Layer.UnıtOfWorks.Concrate;
using Service.Layer.Abstracts;
using Service.Layer.Concretes;

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
        }
    }
}
