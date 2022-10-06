namespace AnimeLife.Extensions;

public static class AppExtensions
{
    public static void RegisterServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
    }

    public static void ConfigureApp(this WebApplication app)
    {
        app.UseHttpsRedirection();
        app.MapControllers();
    }
}