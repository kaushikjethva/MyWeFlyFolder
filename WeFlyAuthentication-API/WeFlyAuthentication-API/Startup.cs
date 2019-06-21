using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WeFlyAuthentication_API.Infrastructure;
using Microsoft.EntityFrameworkCore;
using WeFlyAuthentication_API.Services;
using Swashbuckle.AspNetCore.Swagger;

namespace WeFlyAuthentication_API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<IdentityDbContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("Wefly_IdentityConnection"));
            });

            services.AddScoped<IIdentityManager, IdentityManager>();
            services.AddCors(options => {
                options.AddDefaultPolicy(configure =>
                {
                    configure.AllowAnyOrigin()
                       .AllowAnyHeader()
                       .AllowAnyMethod();
                });
            });

            services.AddSwaggerGen(config =>
            {
                config.SwaggerDoc("v1", new Info
                {
                    Title = "Wefly Identity API",
                    Version = "v1",
                    Contact = new Contact { Name = "Siddhesh Rasam", Email = "siddheshrasam@gmail.com" },
                    Description = "This api gives the function for identify the users for Wefly API  calls."
                });
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            InitializeDatabase(app);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Wefly Identity UI");
                options.RoutePrefix = "";
            });

            app.UseCors();
            app.UseHttpsRedirection();
            app.UseMvc();
        }

        private void InitializeDatabase(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var database = serviceScope.ServiceProvider.GetService<IdentityDbContext>().Database;
                database.Migrate();
            }
        }
    }
}
