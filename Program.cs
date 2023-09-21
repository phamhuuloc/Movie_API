using Microsoft.EntityFrameworkCore;
using MOVIE_API.Container;
using MOVIE_API.Model;
using MOVIE_API.Services;


var builder = WebApplication.CreateBuilder(args);  


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ICustomerServices,CustomerServices> ();
var connectionString = builder.Configuration.GetConnectionString("mysqlConnection");
Console.Write(connectionString);
builder.Services.AddDbContext<MysqlDBContext>(options => {
     options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});
// builder.Services.AddDbContext<MysqlDBContext>(opt =>
//     opt.UseMySql(My));
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
