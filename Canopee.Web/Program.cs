using Canopee.Application;
using Canopee.Persistence;
using Canopee.Web;

using Microsoft.AspNetCore.HttpOverrides;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureWebApplication();
builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.AddScoped<ITreeService, TreeService>();
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddAutoMapper(typeof(Program));

builder.ConfigureLogger();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseHsts();
}
app.UseCors(ServicesConfigurationExtensions.CORS_POLICY_NAME);

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});

app.UseAuthorization();

app.MapControllers();

app.Run();
