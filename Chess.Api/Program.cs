using Chess.Engine;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ChessEngine>();

var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.Map("/engine", (ChessEngine engine) =>
{
    return engine.HelloWorld();
});
app.Run();
