using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Services.Interfaces;
using WebApplication1.Services;

namespace WebApplication1.Utilities.DependencyInjection
{
    public static class DependencyResolver
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            services.AddScoped<IFizzBuzzService, FizzBuzzService>();
        }
    }
}
