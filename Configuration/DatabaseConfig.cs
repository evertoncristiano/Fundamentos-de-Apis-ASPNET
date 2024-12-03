using FundamentosApisASPNET.Data;
using Microsoft.EntityFrameworkCore;

namespace FundamentosApisASPNET.Configuration
{
    public static class DatabaseConfig
    {
        public static WebApplicationBuilder AddDatabaseConfig(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<ApiDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            return builder;
        }
    }
}
