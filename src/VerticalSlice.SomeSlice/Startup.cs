using Microsoft.Extensions.DependencyInjection;

namespace VerticalSlice.SomeSlice
{
    public static class Startup
    {
        public static IServiceCollection AddSomeSliceServices(this IServiceCollection serviceCollection)
        {
            return serviceCollection;
        }
    }
}