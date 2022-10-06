using AnimeLife;
using AnimeLife.Application.DatabaseLayer.Implementations;

var builder = WebApplication.CreateBuilder(args);
builder.RegisterServices(); 

var app = builder.Build();
app.ConfigureApp();

app.Run();


