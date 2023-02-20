using eTickets.Data;
using Microsoft.AspNetCore.Builder;

namespace eTickets
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // DbContext Configuration
            services.AddDbContext<AppDbContext>();

            // Add framework services.
            services.AddControllersWithViews();
        }
    }
}
