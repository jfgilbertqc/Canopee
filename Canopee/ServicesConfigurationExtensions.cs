namespace Canopee
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
    }
}
