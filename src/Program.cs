using linq2db_3632_problem;
using LinqToDB.AspNet;
using LinqToDB.AspNet.Logging;
using LinqToDB.Configuration;

var builder = WebApplication.CreateBuilder(args);


builder.Host.ConfigureServices(services =>
{
    services.AddScoped<IFooService, FooService>();

    services.AddLinqToDBContext<FooDataConnection>((provider, options) =>
     {
         options
             .UseSQLite(builder.Configuration.GetConnectionString("Default"))
             .UseDefaultLogging(provider);
     });
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
