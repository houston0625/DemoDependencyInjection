
using DemoDependencyInjection.Service;
using Microsoft.Extensions.DependencyInjection;

namespace DemoDependencyInjection
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
            
            //builder.Services.AddKeyedSingleton<IComplete, CompleteAdd>("add");
            //builder.Services.AddKeyedSingleton<IComplete, CompleteRemove>("remove");
            //builder.Services.AddKeyedSingleton<IComplete, CompleteEdit>("edit");
            builder.Services.AddScoped<CompleteAdd>();
            builder.Services.AddScoped<CompleteRemove>();
            builder.Services.AddScoped<CompleteEdit>();
            
            builder.Services.AddScoped<FinalService>();


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
