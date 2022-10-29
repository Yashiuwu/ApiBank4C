using Aplication.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Shared
{
    public static class ServiceExtensions
    {
        public static void AddShareInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDateTimeService, IDateTimeService>();
        }
    }
}
