using OCPI;
using OCPI.Versioning;

var builder = WebApplication.CreateBuilder(args);

// Add all required OCPI services to your application
builder.AddOcpi();

var app = builder.Build();

// Add OCPI Exception handling middleware to your request pipeline
app.UseOcpi();

app.Run();