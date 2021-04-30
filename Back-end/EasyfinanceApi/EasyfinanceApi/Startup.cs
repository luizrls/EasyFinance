using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using EasyfinanceApi.Data;
using Microsoft.EntityFrameworkCore;

namespace EasyfinanceApi
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

            services.AddDbContext<EasyfinanceApiContext>(options =>
                    options.UseSqlServer("Data Source=LUIZRLS-PC;Initial Catalog=EasyFinanceDB;Persist Security Info=True;User ID=ADMIN;Password=admin"));

            /*services.AddDbContext<EasyfinanceApiContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("EasyfinanceApiContext")));*/

            /*services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                        // required if AllowCredentials is set also
                        .SetIsOriginAllowed(s => true)
                        //.AllowAnyOrigin()
                        .AllowAnyMethod()  // doesn't work for DELETE!
                        .WithMethods("DELETE")
                        .AllowAnyHeader()
                        .AllowCredentials()
                );
            });

            services.Configure<FormOptions>(o =>
            {
                o.ValueLengthLimit = int.MaxValue;
                o.MultipartBodyLengthLimit = int.MaxValue;
                o.MemoryBufferThreshold = int.MaxValue;
            });


            services.Configure<IISOptions>(o =>
            {
                o.ForwardClientCertificate = false;
            });*/

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen();


            //sigleton do context
            services.AddScoped<EasyfinanceApiContext, EasyfinanceApiContext>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Easy finance Api");
            });

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
