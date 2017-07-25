using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using split.Console.DataAccess;
using split.Console.Interfaces;

namespace split.Console
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();

            HostingEnvironment = env;
        }

        public IConfigurationRoot Configuration { get; }

        public IHostingEnvironment HostingEnvironment { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            // Register application dependencies.
            services.AddScoped<ISplitRepository, SplitRepository>();

            if (HostingEnvironment.IsDevelopment())
            {
                // Add EntityFramework.
                services.AddDbContext<SplitDbContext>(options => options.UseInMemoryDatabase());
            }
            else
            {
                // Add EntityFramework
                //service.AddDbContext<SplitDbContext>(options => options.UseSqlite());
            }

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, SplitDbContext context)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                context.Database.EnsureCreated();
            }
            else
            {
                app.UseExceptionHandler(); // TODO: This should point to a dedicated 404 / error page.
            }

            app.UseMvc();
        }
    }
}
