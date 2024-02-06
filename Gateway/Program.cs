using Ocelot.DependencyInjection;
using Ocelot.Middleware;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Configuration.AddJsonFile("ocelot.json");

        // Add services to the container.
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddOcelot();
        builder.Services.AddSwaggerForOcelot(builder.Configuration);

        System.Console.WriteLine($"SomeVariable: {builder.Configuration.GetValue<string>("SomeVariable")}");

        var app = builder.Build();
        app.UseSwaggerForOcelotUI(opt => { });
        app.UseOcelot().Wait();

        // Configure the HTTP request pipeline.
        app.Run();
    }
}

