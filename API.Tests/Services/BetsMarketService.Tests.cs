using API.Services;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace API.Tests.Services;

public sealed class BetsMarketServiceTests
    : IClassFixture<WebApplicationFactory<Startup>>
{
    public BetsMarketServiceTests(
        WebApplicationFactory<Startup> factory)
    {
        _factory = factory;
    }

    [Fact(DisplayName = $"{nameof(BetsMarketService)} can be created.")]
    [Trait("Category", "Unit")]
    public void CanBeCreated()
    {
        // Arrange
        var logger = Mock.Of<ILogger<BetsMarketService>>();

        // Act
        var exception = Record.Exception(() =>
            new BetsMarketService(logger));

        // Assert
        exception.Should().BeNull();
    }

    [Fact(DisplayName = $"{nameof(BetsMarketService)}" +
        $" can not be created without logger.")]
    [Trait("Category", "Unit")]
    public void CanNotBeCreatedWithoutLogger()
    {
        // Act
        var exception = Record.Exception(() =>
            new BetsMarketService(null!));

        // Assert
        exception.Should().NotBeNull()
            .And.BeOfType<ArgumentNullException>();
    }

    [Fact(DisplayName = $"{nameof(BetsMarketService)}" +
        $" can successfully build.")]
    [Trait("Category", "Unit")]
    public void CanBuildService()
    {
        // Arrange
        var hostBuilder =
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(builder =>
                    builder.UseStartup<Startup>())
                .UseDefaultServiceProvider((c, o) => o.ValidateOnBuild = true);

        // Act
        var exception = Record.Exception(hostBuilder.Build);

        // Assert
        exception.Should().BeNull();
    }

    [Fact(DisplayName = $"{nameof(BetsMarketService)}" +
        $" can health check.")]
    [Trait("Category", "Integration")]
    public async Task CanHealthCheckAsync()
    {
        // Arrange
        using var client = _factory.CreateClient();

        string? response = null;

        // Act
        var exception =
            await Record.ExceptionAsync(async () =>
                    response = await client.GetStringAsync("/hc"));

        // Assert
        exception.Should().BeNull();
        response.Should().NotBeNullOrWhiteSpace().And.Be("Healthy");
    }

    private readonly WebApplicationFactory<Startup> _factory;
}
