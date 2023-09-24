using API.Services;

namespace API.Registrations;

public static class HostedServices
{
    public static IServiceCollection AddHostedServices(
        this IServiceCollection services)
        => services.AddHostedService<BetsMarketService>();
}
