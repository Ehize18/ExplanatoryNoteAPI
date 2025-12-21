using Amazon.S3;
using ExplanatoryNoteAPI.Application.Options;
using ExplanatoryNoteAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace ExplanatoryNoteAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

			var config = builder.Configuration;

			config.AddEnvironmentVariables();

			// Add services to the container.

			builder.Services.AddApplicationCors();
            builder.Services.AddRepositoryFactory();
            builder.Services.AddJwtAuthentication(config.GetSection("Jwt"));
            builder.Services.AddApplicationServices();
            builder.Services.AddFileServices(config);
            builder.Services.AddPostgreSQLDb(config);
            builder.Services.AddEmailService(config);
            builder.Services.AddRedisCaching(config);

            builder.Services.AddControllers().AddNewtonsoftJson();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseCors("DevPolicy");
            }

            //app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

			using var scope = app.Services.CreateScope();

			var context = scope.ServiceProvider.GetRequiredService<ExplanatoryNoteDbContext>();
			context.Database.Migrate();

			app.Run();
        }
    }
}
