using Progi.Test.ServiceLibrary;
using Progi.Test.ServiceLibrary.Interfaces;

namespace Progi.Test.WebApi.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServiceModules(this IServiceCollection services)
        {
            
            services.AddTransient<ICarCalculatorService, CarCalculatorService>();
            return services;
        }

    }
}
