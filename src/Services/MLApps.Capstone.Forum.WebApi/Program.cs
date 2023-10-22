using MLApps.Capstone.Forum.WebApi.Modules.App;
using MLApps.Capstone.Forum.WebApi.Modules.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDependencies();

var app = builder.Build();
app.AddApplication();
app.Run();