using Microsoft.Extensions.DependencyInjection;
using Soenneker.Git.Util.Registrars;
using Soenneker.Runners.Email.Disposables.Utils;
using Soenneker.Runners.Email.Disposables.Utils.Abstract;
using Soenneker.Utils.Dotnet.NuGet.Registrars;
using Soenneker.Utils.Dotnet.Registrars;
using Soenneker.Utils.File.Registrars;
using Soenneker.Utils.FileSync.Registrars;
using Soenneker.Utils.HttpClientCache.Registrar;
using Soenneker.Utils.SHA3.Registrars;

namespace Soenneker.Runners.Email.Disposables;

/// <summary>
/// Console type startup
/// </summary>
public class Startup
{
    // This method gets called by the runtime. Use this method to add services to the container.
    public static void ConfigureServices(IServiceCollection services)
    {
        SetupIoC(services);
    }

    public static void SetupIoC(IServiceCollection services)
    {
        services.AddHttpClientCache();
        services.AddHostedService<ConsoleHostedService>();
        services.AddFileUtilAsScoped();
        services.AddFileUtilSyncAsScoped();
        services.AddGitUtilAsScoped();
        services.AddSha3UtilAsScoped();
        services.AddScoped<IDownloadUtil, DownloadUtil>();
        services.AddScoped<IFileOperationsUtil, FileOperationsUtil>();
        services.AddDotnetNuGetUtilAsScoped();
        services.AddDotnetUtilAsScoped();
    }
}
