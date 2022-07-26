using Microsoft.IdentityModel.Tokens;

namespace CustomerApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddAuthentication();

            services.AddAuthentication()
                .AddJwtBearer("Bearer", options =>
                {
                    options.Authority = Configuration.GetSection("AppSettings")["IDSDomain"];

                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateAudience = false
                    };
                });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("CustomerAppPolicy", policy =>
                {
                    policy.RequireAuthenticatedUser();
                    policy.RequireClaim("scope", "customer-app");
                });
            });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers()
                    .RequireAuthorization("CustomerAppPolicy");
            });
        }
    }
}
