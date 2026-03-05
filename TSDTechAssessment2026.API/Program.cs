using TSDTechAssessment2026.API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ProductService>();

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


app.MapGet("/products", async (ProductService productService) => Results.Ok(await productService.GetProductsLibraryAsync()))
.WithName("products");

app.Run();

