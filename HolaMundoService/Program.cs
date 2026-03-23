var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api", () => "Hello World 5 !");

app.Run();
