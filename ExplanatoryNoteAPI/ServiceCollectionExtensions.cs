using System.Text;
using ExplanatoryNoteAPI.Application.Interfaces;
using ExplanatoryNoteAPI.Application.Services;
using ExplanatoryNoteAPI.Core;
using ExplanatoryNoteAPI.Core.Entities;
using ExplanatoryNoteAPI.Database;
using ExplanatoryNoteAPI.Database.Repositories;
using ExplanatoryNoteAPI.Utilities.Jwt;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace ExplanatoryNoteAPI
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddRepositoryFactory(this IServiceCollection services)
		{
			services.AddScoped<IRepositoryFactory, RepositoryFactory>();

			return services;
		}

		public static IServiceCollection AddPostgreSQLDb(this IServiceCollection services, IConfiguration config)
		{
			var connectionString = config["POSTGRES_CONNECTION_STRING"];

			if (string.IsNullOrWhiteSpace(connectionString))
			{
				connectionString = config.GetConnectionString("PostgreSQL")!;
			}

			services.AddDbContext<ExplanatoryNoteDbContext>(builder =>
			{
				builder.UseNpgsql(connectionString);
			});

			services.AddSingleton<ITypeResolver, TypeResolver>();
			services.AddScoped<IUnitOfWork, UnitOfWork>();

			return services;
		}

		public static IServiceCollection AddJwtAuthentication(this IServiceCollection services, IConfiguration jwtConfig)
		{
			var securityKey = new SymmetricSecurityKey(
					Encoding.UTF8.GetBytes(jwtConfig.GetValue<string>("SecretKey")!));

			services.Configure<JwtOptions>(jwtConfig);
			services.AddScoped<IJwtProvider, JwtProvider>();

			services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
				.AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
				{
					options.TokenValidationParameters = new()
					{
						ValidateIssuer = false,
						ValidateAudience = false,
						ValidateLifetime = true,
						ValidateIssuerSigningKey = true,
						IssuerSigningKey = securityKey
					};
					options.Events = new JwtBearerEvents()
					{
						OnMessageReceived = context =>
						{
							context.Token = context.Request.Cookies["Token"];
							return Task.CompletedTask;
						}
					};
				});

			return services;
		}

		public static IServiceCollection AddApplicationServices(this IServiceCollection services)
		{
			services.AddScoped<IAuthService, AuthService>();
			services.AddScoped<IGenericDataService, GenericDataService>();
			services.AddScoped<IExportService, ExportService>();

			return services;
		}

		public static IServiceCollection AddApplicationCors(this IServiceCollection services)
		{
			services.AddCors(
				o => o.AddPolicy("DevPolicy",
					builder => builder
						.AllowAnyOrigin()
						.AllowAnyHeader()
						.AllowAnyMethod()));
			return services;
		}
	}
}
