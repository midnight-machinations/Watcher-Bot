using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using NetCord.Hosting.Gateway;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

// Load bot token from env into appsettings config
builder.Configuration.AddInMemoryCollection(
    new Dictionary<string, string?> { ["Discord:Token"] = builder.Configuration["DISCORD_TOKEN"] }
);

builder.Services.AddDiscordGateway();

var host = builder.Build();

await host.RunAsync();
