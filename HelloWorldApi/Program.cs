var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/hello", (string? name) =>
{
    var greetings = new[]
    {
        "Hello",
        "Hi",
        "Hey",
        "Greetings",
        "Welcome",
        "Howdy",
        "Good day"
    };
    
    var randomGreeting = greetings[Random.Shared.Next(greetings.Length)];
    var userName = string.IsNullOrWhiteSpace(name) ? "World" : name;
    
    return $"{randomGreeting}, {userName}!";
})
.WithName("GetHelloWorld");

app.Run();
