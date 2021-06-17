using Estetika.Api.Core;
using Estetika.Application;
using Estetika.Application.Commands;
using Estetika.Application.Email;
using Estetika.Application.Queries;
using Estetika.DataAccess;
using Estetika.Implementation.Commands;
using Estetika.Implementation.Email;
using Estetika.Implementation.Logging;
using Estetika.Implementation.Queries;
using Estetika.Implementation.Validators;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Nedelja7.Api.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            services.AddTransient<ICreateServiceTypeCommand, EfCreateServiceTypeCommand>();
            services.AddTransient<ICreateJawJawSideTeethCommand, EfCreateJawJawSideTeethCommand>();
            services.AddTransient<ICreateAppointmentCommand, EfCreateAppointmentCommand>();
            services.AddTransient<ICreateUserCommand, EfCreateUserCommand>();
            services.AddTransient<ICreateEKartonCommand, EfCreateEKartonCommand>();

            services.AddTransient<IDeleteRoleCommand, EfDeleteRoleCommand>();
            services.AddTransient<IDeleteDentistCommand, EfDeleteDentistCommand>();
            services.AddTransient<IDeleteTeethCommand, EfDeleteTeethCommand>();
            services.AddTransient<IDeleteJawCommand, EfDeleteJawCommand>();
            services.AddTransient<IDeleteJawSideCommand, EfDeleteJawSideCommand>();
            services.AddTransient<IDeleteServiceTypeCommand, EfDeleteServiceTypeCommand>();
            services.AddTransient<IDeleteUserCommand, EfDeleteUserCommand>();
            services.AddTransient<IDeleteEKartonCommand, EfDeleteEKartonCommand>();

            services.AddTransient<IUpdateRoleCommand, EfUpdateRoleCommand>();
            services.AddTransient<IUpdateDentistCommand, EfUpdateDentistCommand>();
            services.AddTransient<IUpdateTeethCommand, EfUpdateTeethCommand>();
            services.AddTransient<IUpdateJawCommand, EfUpdateJawCommand>();
            services.AddTransient<IUpdateJawSideCommand, EfUpdateJawSideCommand>();
            services.AddTransient<IUpdateServiceTypeCommand, EfUpdateServiceTypeCommand>();
            services.AddTransient<IUpdateJawJawSideTeethCommand, EfUpdateJawJawSideTeethCommand>();
            services.AddTransient<IUpdateUserCommand, EfUpdateUserCommand>();
            services.AddTransient<IUpdateEKartonCommand, EfUpdateEKartonCommand>();

            services.AddTransient<IGetRoleQuery, EfGetRoleQuery>();
            services.AddTransient<IGetServiceTypeQuery, EfGetServiceTypeQuery>();
            services.AddTransient<IGetDentistQuery, EfGetDentistQuery>();
            services.AddTransient<IGetUsersQuery, EfGetUsersQuery>();
            services.AddTransient<IGetEKartonQuery, EfGetEKartonQuery>();
            services.AddTransient<IGetUseCaseLogQuery, EfGetUseCaseLogQuery>();
            services.AddTransient<IGetAppointmentQuery, EfGetAppointmentQuery>();


            services.AddTransient<IGetOneRoleQuery, EfGetOneRoleQuery>();
            services.AddTransient<IGetOneServiceTypeQuery, EfGetOneServiceTypeQuery>();
            services.AddTransient<IGetOneDentistQuery, EfGetOneDentistQuery>();
            services.AddTransient<IGetOneUserQuery, EfGetOneUserQuery>();
            services.AddTransient<IGetOneEKartonQuery, EfGetOneEKartonQuery>();

            services.AddHttpContextAccessor();
            services.AddTransient<IApplicationActor>(x => {

                var accessor = x.GetService<IHttpContextAccessor>();

                var user = accessor.HttpContext.User;

                if (user.FindFirst("ActorData") == null)
                {
                    return new AnonymousActor();
                }

                var actorString = user.FindFirst("ActorData").Value;

                var actor = JsonConvert.DeserializeObject<JwtActor>(actorString);

                return actor;
            });

            services.AddTransient<UseCaseExecutor>();
            services.AddTransient<JWTManager>();
            services.AddTransient<IUseCaseLogger, DatabaseUseCaseLogger>();
            services.AddTransient<IEmailSender, SmtpEmailSender>();

            services.AddTransient<CreateRoleValidator>();
            services.AddTransient<CreateDentistValidator>();
            services.AddTransient<CreateTeethValidator>();
            services.AddTransient<CreateJawValidator>();
            services.AddTransient<CreateJawSideValidator>();
            services.AddTransient<CreateServiceTypeValidator>();
            services.AddTransient<CreateJawJawSideTeethValidator>();
            services.AddTransient<CreateAppointmentValidator>();
            services.AddTransient<CreateUsertValidator>();
            services.AddTransient<CreateEKartonValidator>();

            services.AddTransient<UpdateRoleValidator>();
            services.AddTransient<UpdateDentistValidator>();
            services.AddTransient<UpdateTeethValidator>();
            services.AddTransient<UpdateJawValidator>();
            services.AddTransient<UpdateJawSideValidator>();
            services.AddTransient<UpdateServiceTypeValidator>();
            services.AddTransient<UpdateJawJawSideTeethValidator>();
            services.AddTransient<UpdateUserValidator>();
            services.AddTransient<UpdateEKartonValidator>();


            services.AddAuthentication(options =>
            {
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(cfg =>
            {
                cfg.RequireHttpsMetadata = false;
                cfg.SaveToken = true;
                cfg.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = "asp_api",
                    ValidateIssuer = true,
                    ValidAudience = "Any",
                    ValidateAudience = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ThisIsMyVerySecretKey")),
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
            });



            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Estetika.Api", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                        Reference = new OpenApiReference
                            {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header,

                        },
                        new List<string>()
                    }
                });
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
