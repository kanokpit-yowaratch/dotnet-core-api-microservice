using ProductService.Model;
using ProductService.Repository;
using ProductService.Settings;

var builder = WebApplication.CreateBuilder(args);

// Bind mongodb settings
builder.Services.Configure<MongoDbSettings>(
    builder.Configuration.GetSection(nameof(MongoDbSettings)));

// Add services to the container.
// Add the Repositories
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
// Add Product Repository
builder.Services.AddScoped<IProductRepository, ProductRepository>();

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

app.UseAuthorization();

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
