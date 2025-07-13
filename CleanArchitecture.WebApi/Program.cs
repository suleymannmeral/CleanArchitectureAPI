using CleanArchitecture.WebApi.Configurations;
using CleanArchitecture.WebApi.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .InstalLService(
    builder.Configuration,typeof(IServiceInstaller).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseMiddlewareExtensions();
app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
