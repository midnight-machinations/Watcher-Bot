using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using NetCord.Hosting.Gateway;
using NetCord.Hosting.Services;
using NetCord.Hosting.Services.ApplicationCommands;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

// Load bot token from env into appsettings config
builder.Configuration.AddInMemoryCollection(
    new Dictionary<string, string?> { ["Discord:Token"] = builder.Configuration["DISCORD_TOKEN"] }
);

builder.Services.AddDiscordGateway().AddApplicationCommands();

var host = builder.Build();

host.AddModules(typeof(Program).Assembly);

await host.RunAsync();
