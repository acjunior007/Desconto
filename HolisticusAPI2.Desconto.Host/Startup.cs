using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzimuteLib.Log;
using HolisticusAPI2.Desconto.Application;
using HolisticusAPI2.Desconto.Application.Services;
using HolisticusAPI2.Desconto.Application.Interfaces;
using HolisticusAPI2.Desconto.Application.Validator;

using HolisticusAPI2.Desconto.Domain.Interfaces.Services;



using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using HolisticusAPI2.Desconto.Domain.Services;
using HolisticusAPI2.Desconto.Domain.Interfaces.Repositories;
using HolisticusAPI2.Desconto.Infra.SQLServer.Repositories;
using HolisticusAPI2.Desconto.Infra.Log;
using HolisticusAPI2.Desconto.Infra.SQLServer.Interfaces;
using HolisticusAPI2.Desconto.Infra.SQLServer.Maps;
using HolisticusAPI2.Desconto.Infra.SQLServer.Contexts;
using Microsoft.EntityFrameworkCore;
using HolisticusAPI2.Paciente.Infra.Config;
using HolisticusAPI2.Paciente.Infra.File;

namespace HolisticusAPI2.Desconto.Host
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
            services.AddControllers();

            string sgipConnectionString = Configuration["Holisticus2API-SGIP-Connectionstring"];
            if (string.IsNullOrWhiteSpace(sgipConnectionString))
            {
                throw new ApplicationException("A connectionstring capturada não é válida");
            }

            services.AddDbContext<SGIPDbContext>(options => options
                .EnableSensitiveDataLogging()
                .UseSqlServer(sgipConnectionString));

            services.AddScoped<IDescontoAppService, DescontoAppService>();
            services.AddScoped<IDescontoValidator, DescontoValidator>();
            services.AddScoped<IDescontoService, DescontoService>();
            services.AddScoped<IDescontoRepository, DescontoRepository>();
            services.AddScoped<IRepositoryBase<DescontoDbMap>, RepositoryBase<DescontoDbMap>>();

            services.AddScoped<IFileManagerRepository, FileManagerRepository>();
            services.AddScoped<IConfigManagerRepository, ConfigManagerRepository>();
            services.AddScoped<IEventLogger, EventLogger>();

            services.AddScoped<IAzimuteLogger, AzimuteLogger>(provider =>
                new AzimuteLogger(provider.GetService<IConfiguration>(), "HolisticusAPI2", "Pacientes", "Atendimento"));

            
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
        }
    }
}
