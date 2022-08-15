using IBVL.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace IBLV.Web.Api.Configurations
{
    public static class SqlServerConfig
    {
        public static void AddSqlServerContext(this WebApplicationBuilder builder)
        {

            builder.Services.AddDbContext<SqlServerContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("IBVLDb")));

            builder.Services.AddScoped<SqlServerContext>();
        }
    }
}
