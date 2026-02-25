using Assignment1.Interfaces;
using Assignment1.Services;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSingleton<IBrainRotterService, BrainRotterService>();
builder.Services.AddSingleton<IViralAilmentService, ViralAilmentService>();
var app = builder.Build();
app.MapControllers();


app.Run();
