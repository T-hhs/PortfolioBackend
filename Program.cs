using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using PortfolioBackend.Features.Blogs;
using PortfolioBackend.Features.Projects;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddValidation();



var connectionString =
    builder.Configuration.GetConnectionString("backendDB_Correct")
    ?? throw new InvalidOperationException(
        "Connection string 'backendDB_Correct' was not found.");

builder.Services.AddDbContext<backendDB>(options =>
    options.UseNpgsql(connectionString));


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
    });
    
    app.MapOpenApi();
}

app.MapAllBlogEndpoints();
app.MapAllProjectEndpoints();

app.Run();


