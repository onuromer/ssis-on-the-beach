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
using Microsoft.OpenApi.Models;
using RepoDb;
using Ssiws.Business.Implementations;
using Ssiws.Business.Interfaces;
using Ssiws.Web.Api.Conventions;
using Ssiws.Web.Api.Features;

namespace Ssiws.Web.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            RepoDb.SqlServerBootstrap.Initialize();
        }

        public IConfiguration Configuration { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IAppSettings>(Configuration.GetSection("StandartSettings").Get<StandartSettings>());
            services.AddSingleton<IStorage,Storage>();
            services.AddControllers();
            services.
                AddMvc(o => o.Conventions.Add(new GenericControllerRouteConvention())).
                ConfigureApplicationPartManager(m => m.FeatureProviders.Add(new GenericTypeControllerFeatureProvider()));
            services.AddOptions();
            services.AddSwaggerGen(c =>
            {
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "An API for SSIS", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "SSIWS V1");
            });
        }
    }
}
