
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
builder.Services.AddSignalR();

// Allows the server to locate and serve the index.html file.
app.UseDefaultFiles();
app.UseStaticFiles();
app.MapHub<ChatHub>("/Hubs");

app.MapGet("/", () => "Hello World!");

app.Run();
