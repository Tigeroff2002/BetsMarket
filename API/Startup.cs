using API.Registrations;
using Microsoft.Extensions.DependencyInjection;

namespace API;

/// <summary>
/// Класс начальной конфигурации сервиса.
/// </summary>
public class Startup
{
    /// <summary>
    /// Создает новый экземпляр <see cref="Startup"/>.
    /// </summary>
    /// <param name="configuration">
    /// Конфигурация сервиса.
    /// </param>
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration 
            ?? throw new ArgumentNullException(nameof(configuration));
    }

    /// <summary>
    /// Конфигурация.
    /// </summary>
    public IConfiguration Configuration { get; }

    /// <summary>
    /// Этот метод вызывается средой выполнения.
    /// </summary>
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        services
            .AddHttpClient()
            .AddLogging()
            .AddHostedServices()
            .AddHealthChecks();
    }

    /// <summary>
    /// Этот метод вызывается средой выполнения.
    /// </summary>
    public void Configure(IApplicationBuilder app)
    {
        ArgumentNullException.ThrowIfNull(app);

        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);

        _ = app.UseRouting()
            .UseEndpoints(endpoints =>
            {
                _ = endpoints.MapHealthChecks("/hc");
                _ = endpoints.MapControllers();
            });
    }
}

