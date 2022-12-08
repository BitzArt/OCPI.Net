var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add all required OCPI services to your application
builder.AddOcpi();

var app = builder.Build();

// Add OCPI Exception handling middleware to your request pipeline
app.UseOcpiExceptionHandler();

app.MapControllers();

app.Run();