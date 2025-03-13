var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/test-env", (IConfiguration config) =>
{
    return Results.Ok(new
    {
        Environment = builder.Environment.EnvironmentName,
        Urls = config["Urls"]
    });
});

app.MapControllers();
app.Run();
