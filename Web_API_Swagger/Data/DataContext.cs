using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Web_API_Swagger.Data
{
    public class DataContect : IdentityDbContext
    {
        public DataContect(DbContextOptions<DataContect> options)
            : base(options)
        {
        }
    }
}
