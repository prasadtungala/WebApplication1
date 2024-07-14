using WebApplication1.Services.Interfaces;
using WebApplication1.Services;

namespace WebApplication1.Utilities.Factory
{
    public static class ServiceFactory
    {
        public static IFizzBuzzService CreateFizzBuzzService()
        {
            return new FizzBuzzService();
        }
    }

}
