using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
// ConfigureServices method
builder.Services.AddControllersWithViews();


var app = builder.Build();



//app.MapGet("/", () => "Hello World!");


// Configure method


    var env = app.Services.GetRequiredService<IWebHostEnvironment>();

    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }

    app.UseRouting();

    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
    });


app.Run();

