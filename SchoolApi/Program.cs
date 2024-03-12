
using Microsoft.EntityFrameworkCore;
using School.Infrastructure.Data;
using School.Infrastructure;
using School.Core;
using School.Service;
using Microsoft.Extensions.DependencyInjection;
namespace SchoolApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();
            builder.Services.AddControllers();
            //Add Database
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); 
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
        
            //Add Dependencies
            builder.Services.AddInfrastrucureDependecies()
                            .AddServiceDependencies()
                            .AddCoreDependencies();

           
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
        }
    }
}
