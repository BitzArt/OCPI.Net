using OCPI;

var builder = WebApplication.CreateBuilder(args);

// Add all required OCPI services to your application
builder.AddOcpi();

var app = builder.Build();

// Add predefined OCPI Request pipeline.
// This includes exception handling middleware and mapping controllers
app.UseOcpi();

app.Run();