using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using userAsp.Entities;
using userAsp.Services;

var builder = WebApplication.CreateBuilder(args);

Env.Load();

// Add services to the container.
builder.Configuration.AddEnvironmentVariables();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
   c.EnableAnnotations();
});
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddEntityFrameworkMySQL()
    .AddDbContext<UsersContext>(options =>
    {
        options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection"));
    });
                

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
