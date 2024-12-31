using DrawnFromSteel.Models;
using Microsoft.EntityFrameworkCore;

namespace DrawnFromSteel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDataProtection();

            builder.Services.AddControllers();

            builder.Services.AddDbContext<DFSContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DFSDatabase")));


            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            WebApplication app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
