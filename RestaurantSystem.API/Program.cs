using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using RestaurantSystem.Application.Handlers.CommandHandlers;
using RestaurantSystem.Application.Handlers.QueryHandlers;
using RestaurantSystem.Application.IRepositories.Command;
using RestaurantSystem.Application.IRepositories.Command.Base;
using RestaurantSystem.Application.IRepositories.Query;
using RestaurantSystem.Application.IRepositories.Query.Base;
using RestaurantSystem.Application.Mapper;
using RestaurantSystem.Infrastructure.Data;
using RestaurantSystem.Infrastructure.Repositories.Command;
using RestaurantSystem.Infrastructure.Repositories.Command.Base;
using RestaurantSystem.Infrastructure.Repositories.Query;
using RestaurantSystem.Infrastructure.Repositories.Query.Base;

namespace RestaurantSystem.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddDbContext<RestaurantDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
            );

            builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(AddRestaurantHandler).Assembly));
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(AddFeedbackHandler).Assembly));
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(AddFeedbackResponseHandler).Assembly));
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetFeedbackHandler).Assembly));
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetRestaurantHandler).Assembly));


            builder.Services.AddScoped(typeof(ICommandRepository<>), typeof(CommandRepository<>));
            builder.Services.AddScoped<IRestaurantCommandRepository, RestaurantCommandRepository>();
            builder.Services.AddScoped<IFeedbackCommandRepository, FeedbackCommandRepository>();
            builder.Services.AddScoped<IFeedbackResponseCommandRepository, FeedbackResponseCommandRepository>();


            builder.Services.AddScoped(typeof(IQueryRepository<>), typeof(QueryRepository<>));
            builder.Services.AddScoped<IRestaurantQueryRepository, RestaurantQueryRepository>();
            builder.Services.AddScoped<IFeedbackQueryRepository, FeedbackQueryRepository>();

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

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
