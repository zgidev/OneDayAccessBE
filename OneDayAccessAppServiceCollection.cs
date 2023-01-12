using OneDayAccess.Business.Services;
using OneDayAccess.Interfaces.IRepositories;
using OneDayAccess.Interfaces.IServices;
using OneDayAccess.Repositories;

namespace OneDayAccess
{
    public static class OneDayAccessAppServiceCollectionExtension
    {
        public static IServiceCollection AddOneDayAccessAppServices(this IServiceCollection services)
        {
            services.AddScoped<IEmailService, EmailService>();

            services.AddScoped<IActiveDirectoryService, ActiveDirectoryService>();
            services.AddScoped<IInitiatorService, InitiatorService>();
            services.AddScoped<IMovedItemsService, MovedItemsService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IInitiatorRepository, InitiatorRepository>();
            services.AddScoped<IMovedItemsRepository, MovedItemsRepository>();
            services.AddScoped<IDepartmentalRepository, DepartmentalRepository>();

            return services;
        }

    }
}
