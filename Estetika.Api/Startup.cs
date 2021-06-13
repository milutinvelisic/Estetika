using Estetika.Api.Core;
using Estetika.Application;
using Estetika.Application.Commands;
using Estetika.DataAccess;
using Estetika.Implementation.Commands;
using Estetika.Implementation.Validators;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estetika.Api
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
            services.AddTransient<EstetikaContext>();

            services.AddTransient<ICreateRoleCommand, EfCreateRoleCommand>();
            services.AddTransient<ICreateDentistCommand, EfCreateDentistCommand>();
            services.AddTransient<ICreateTeethCommand, EfCreateTeethCommand>();
            services.AddTransient<ICreateJawCommand, EfCreateJawCommand>();
            services.AddTransient<ICreateJawSideCommand, EfCreateJawSideCommand>();

            services.AddTransient<IDeleteRoleCommand, EfDeleteRoleCommand>();
            services.AddTransient<IDeleteDentistCommand, EfDeleteDentistCommand>();
            services.AddTransient<IDeleteTeethCommand, EfDeleteTeethCommand>();
            services.AddTransient<IDeleteJawCommand, EfDeleteJawCommand>();
            services.AddTransient<IDeleteJawSideCommand, EfDeleteJawSideCommand>();

            services.AddTransient<IUpdateRoleCommand, EfUpdateRoleCommand>();
            services.AddTransient<IUpdateDentistCommand, EfUpdateDentistCommand>();
            services.AddTransient<IUpdateTeethCommand, EfUpdateTeethCommand>();
            services.AddTransient<IUpdateJawCommand, EfUpdateJawCommand>();
            services.AddTransient<IUpdateJawSideCommand, EfUpdateJawSideCommand>();


            services.AddTransient<IApplicationActor, AdminFakeApiActor>();

            services.AddTransient<UseCaseExecutor>();


            services.AddTransient<CreateRoleValidator>();
            services.AddTransient<CreateDentistValidator>();
            services.AddTransient<CreateTeethValidator>();
            services.AddTransient<CreateJawValidator>();
            services.AddTransient<CreateJawSideValidator>();

            services.AddTransient<UpdateRoleValidator>();
            services.AddTransient<UpdateDentistValidator>();
            services.AddTransient<UpdateTeethValidator>();
            services.AddTransient<UpdateJawValidator>();
            services.AddTransient<UpdateJawSideValidator>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Estetika.Api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Estetika.Api v1"));
            }

            app.UseRouting();

            app.UseMiddleware<GlobalExceptionHandler>();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
