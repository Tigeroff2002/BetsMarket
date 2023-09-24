#pragma warning disable CA1812
using API;

await Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder =>
        webBuilder.UseStartup<Startup>())
    .Build()
    .RunAsync()
    .ConfigureAwait(false);
#pragma warning restore CA1812