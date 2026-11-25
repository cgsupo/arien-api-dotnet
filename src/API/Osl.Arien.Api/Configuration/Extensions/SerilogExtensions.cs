using Serilog;
using Serilog.Events;

namespace Osl.Arien.Api.Configuration.Extensions;

public static class SerilogExtensions
{
    public static IServiceCollection AddSerilogLogging(this IServiceCollection services)
    {
        services.AddSerilog((_, loggerConfiguration) => loggerConfiguration
            .MinimumLevel.Information()
            .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
            .MinimumLevel.Override("Microsoft.EntityFrameworkCore", LogEventLevel.Warning)
            .Enrich.FromLogContext()
            .Enrich.WithProperty("Module", "Host")
            .WriteTo.Console(outputTemplate:
                "[{Timestamp:HH:mm:ss} {Level:u3}] [{Module}] {Context} {CorrelationId} {Message:lj}{NewLine}{Exception}"));

        return services;
    }
}
