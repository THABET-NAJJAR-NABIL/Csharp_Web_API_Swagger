using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_Swagger
{
   public interface Installer
    {
        void InstallerService(IServiceCollection services, IConfiguration configuration);
    }
}
