using Microsoft.EntityFrameworkCore;
using UserServices.Context;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DbContext");
// Add services to the container.
builder.Services.AddDbContext<DataContext>(
    option => option.UseSqlServer(connectionString)
);
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
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
app.UseCors("corsapp");
app.UseAuthorization();

app.MapControllers();

app.Run();
