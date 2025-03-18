var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddMvc();
builder.Services.AddControllers();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
//app.MapDefaultControllerRoute();
app.MapControllers();

app.Run();
