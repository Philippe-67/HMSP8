using Microsoft.EntityFrameworkCore;
using MSGestionDesPraticiens.Data;
using MSGestionDesPraticiens.Services;

var builder = WebApplication.CreateBuilder(args);
// Configuration des services
builder.Services.AddDbContext<PraticienDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add the services for PraticienService and IPraticienService.
builder.Services.AddScoped<IPraticienService, PraticienService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
