using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


namespace Web_API_Swagger.Installers
{
    public static class InstallerExtentions
    {
        public static void InstallerServicesAssembly(this IServiceCollection services, IConfiguration configuration)
        {
            var installers = typeof(Startup).Assembly.ExportedTypes.Where(x =>
            typeof(Installer).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).Select(Activator.CreateInstance).Cast<Installer>().ToList();
            installers.ForEach(installer => installer.InstallerService(services, configuration));
        }
    }
}
