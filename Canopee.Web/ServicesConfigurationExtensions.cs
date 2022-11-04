using Serilog;

namespace Canopee.Web
{
    public static class ServicesConfigurationExtensions
    {
        public const string CORS_POLICY_NAME = "CorsPolicy";
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(CORS_POLICY_NAME, builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });
        }

        public static void Configure(this IServiceCollection services)
        {
            services.ConfigureCors();
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public static void ConfigureLogger(this WebApplicationBuilder builder)
        {
            builder.Host.UseSerilog((hostingContext, loggerConfiguration) =>
            {
                loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration);
            });
            builder.Services.AddScoped<Common.ILogger, Logger.SeriLog.Logger>();
        }
    }
}
