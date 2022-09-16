using Microsoft.EntityFrameworkCore;
using backend.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// conectar con sql
const string CONNECTIONNAME = "ClienteDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

// context
builder.Services.AddDbContext<ClienteDBContext>(options => options.UseSqlServer(connectionString));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//5. Cors Configuration

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CorsPolicy", builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});
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
// 6. Tell app to use CORS

app.UseCors("CorsPolicy");

app.Run();
