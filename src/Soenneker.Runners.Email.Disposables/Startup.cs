using Microsoft.Extensions.DependencyInjection;
using Soenneker.Managers.Runners.Registrars;
using Soenneker.Utils.File.Download.Registrars;

namespace Soenneker.Runners.Email.Disposables;

/// <summary>
/// Console type startup
/// </summary>
public class Startup
{
    // This method gets called by the runtime. Use this method to add services to the container.
    /// <summary>
    /// Configures services.
    /// </summary>
    /// <param name="services">The service collection.</param>
    public static void ConfigureServices(IServiceCollection services)
    {
        SetupIoC(services);
    }

    /// <summary>
    /// Registers the services required by the application.
    /// </summary>
    /// <param name="services">Service collection that receives the registration.</param>
    /// <returns>The same service collection, so additional registrations can be chained.</returns>
    public static IServiceCollection SetupIoC(IServiceCollection services)
    {
        services.AddHostedService<ConsoleHostedService>().AddRunnersManagerAsSingleton().AddFileDownloadUtilAsSingleton();

        return services;
    }
}
