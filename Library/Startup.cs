using BusinessLayerLibrary.Services.Implementation;
using BusinessLayerLibrary.Services.Interfaces;
using DataLayerLibrary;
using DataLayerLibrary.Services.Implementation;
using DataLayerLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Library
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
            services.AddAutoMapper(typeof(Startup));
            services.AddDbContext<LibraryDBContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Library", Version = "v1" });
            });
            services.AddScoped<IPublisherBusinessLayer, PublisherBusinessLayer>();
            services.AddScoped<IPublisherDataLayerServices, PublisherDataLayerServices>();
            services.AddScoped<IAuthorBussinessLayer,AuthorBusinessLayer>();
            services.AddScoped<IAuthorDataLayerServices,AuthorDataLayerServices>();
            services.AddScoped<IBookBusinessLayerServices, BookBusinessLayerServices>();
            services.AddScoped<IBookDataLayerServices, BookDataLayerServices>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Library v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
