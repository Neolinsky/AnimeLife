namespace AnimeLife;

public static class AppExtensions
{
    public static void RegisterServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        builder.Services.AddOptions();
        builder.Configuration.AddJsonFile("appsettings.json", true, true);
    }

    public static void ConfigureApp(this WebApplication app)
    {
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
    }
}