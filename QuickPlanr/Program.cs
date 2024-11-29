
using Microsoft.EntityFrameworkCore;
using QuickPlanr.Data;
using QuickPlanr.Services;

namespace QuickPlanr
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

            // Add services to the container, including AppDbContext for PostgreSQL
            //Gets ConnectionString from appsettings.json
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Add other necessary services like Identity or Authentication
            builder.Services.AddAuthentication();
            builder.Services.AddAuthorization();

            builder.Services.AddScoped<IUserService, UserService>();

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseRouting();

            app.MapControllers();

            app.Run();
        }
    }
}
