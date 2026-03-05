using TSDTechAssessment2026.WWW.Services;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient("ProductsBaseAPI", client =>
{
	//TODO : Move the base address to appsettings.json
	client.BaseAddress = new Uri("https://localhost:7294");
	client.Timeout = TimeSpan.FromSeconds(30);
});

builder.Services.AddScoped<ProductApiService>();

builder.CreateUmbracoBuilder()
    .AddBackOffice()
    .AddWebsite()
    .AddComposers()
    .Build();

WebApplication app = builder.Build();

await app.BootUmbracoAsync();


app.UseUmbraco()
    .WithMiddleware(u =>
    {
        u.UseBackOffice();
        u.UseWebsite();
    })
    .WithEndpoints(u =>
    {
        u.UseBackOfficeEndpoints();
        u.UseWebsiteEndpoints();
    });

await app.RunAsync();
