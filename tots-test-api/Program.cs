using System.Runtime.ConstrainedExecution;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

//id de la app Azure:
//Id.de aplicación(cliente): fde82289 - 6495 - 4ceb - 9745 - f0d5e1c9c09a
//Id.de directorio(inquilino): f8cdef31 - a31e - 4b4a - 93e4 - 5f571e91255a
//Identificador de objeto: e6548bdf - a70b - 4749 - b796 - 130c23f6af3b