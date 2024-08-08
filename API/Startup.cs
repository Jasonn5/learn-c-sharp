using DataAccess.Context;
using DataAccess.Repositories;
using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Services;
using Services.Interfaces;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }


        public void ConfigureServices(IServiceCollection services) 
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            RegisterTypes(services);

            services.AddDbContext<APIContext>(options => 
            {
                options.UseSqlServer(Configuration.GetConnectionString("APIDatabase"), b => b.MigrationsAssembly("API"));
            });

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) 
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseRouting();
                app.UseAuthentication();
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                    endpoints.MapGet("/", async context =>
                    {
                        await context.Response.WriteAsync("Todo Bien");
                    });
                });
            }
        }

        public static void RegisterTypes(IServiceCollection services) 
        {
            //Contection beetween EntityFramework and Project Context
            services.AddTransient<DbContext, APIContext>();

            //Connection for Employee
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
