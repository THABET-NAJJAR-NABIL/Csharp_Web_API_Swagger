using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_Swagger.Data
{
    public class DbInstaller : Installer
    {
        public void InstallerService(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContect>(options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<DataContect>();
        }
    }
} 
