
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Entity;
using WebApplication2.Services;

namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IStudentService, StudentService>();
            //////////
            builder.Services.AddDbContext<SchoolContext>(
                opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("con"))
                );
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("MyPolicy", corsPolicy =>
                {
                    corsPolicy.AllowAnyHeader()
                              .AllowAnyMethod()
                              .AllowAnyOrigin();
                });
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.UseCors("MyPolicy");  
            app.MapControllers();

            app.Run();
        }
    }
}
