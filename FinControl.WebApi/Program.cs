using FinControl.Domain.Options;
using FinControl.WebApi.Extensions;
using Scalar.AspNetCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

JwtOptions jwtOptions = builder.Configuration.GetRequiredSection(JwtOptions.SectionName).Get<JwtOptions>()!;
builder.Services.SetupAuthentication(jwtOptions);

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(opt => opt.EnablePersistentAuthentication());
}

app.UseHttpsRedirection();

app.Run();
