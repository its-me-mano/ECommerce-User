using AutoMapper;
using ECommerce_User.Contracts;
using ECommerce_User.Controllers;
using ECommerce_User.Dbcontexts;
using ECommerce_User.Repositories;
using ECommerce_User.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Serialization;
using System;
using System.Text;

namespace ECommerce_User
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
              services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
             .AddJwtBearer(options =>
             {
                
                 options.TokenValidationParameters = new TokenValidationParameters
                 {
                     ValidateIssuer = true,
                     ValidateAudience = true,
                     ValidateLifetime = true,
                     ValidateIssuerSigningKey = true,
                     ValidIssuer = Configuration["Jwt:Issuer"],
                     ValidAudience = Configuration["Jwt:Audience"],
                     IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                 };
                 
             });

            services.AddControllers(setupAction =>
            {
                setupAction.ReturnHttpNotAcceptable = true;
            }).AddNewtonsoftJson(setupAction =>
            {
                setupAction.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            }).AddXmlDataContractSerializerFormatters();

            services.AddScoped<ILoginRepositories, LoginRepositories>();
            services.AddScoped<ILoginServices, LoginServices>();
            services.AddScoped<IUserDetailRepositories, UserDetailsRepositories>();
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<IMetaDataRepositories, MetaDataRepositories>();
            services.AddScoped<IMetaDataServices, MetaDataServices>();
            services.AddScoped<IFileRepositories, FileRepositories>();
            services.AddScoped<IFileServices, FileServices>();
            services.AddDistributedMemoryCache();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            var serviceProvider = services.BuildServiceProvider();
            var logger = serviceProvider.GetService<ILogger<LoginController>>();
            var logger1 = serviceProvider.GetService<ILogger<UserController>>();
            var logger3 = serviceProvider.GetService<ILogger<FileController>>();
            var logger2 = serviceProvider.GetService<ILogger<MetaDataController>>();
            services.AddSingleton(typeof(ILogger), logger);
            services.AddSingleton(typeof(ILogger), logger1);
            services.AddSingleton(typeof(ILogger), logger2);
            services.AddSingleton(typeof(ILogger), logger3);


            services.AddDbContext<UserDetailsContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler(appBuilder =>
                {
                    appBuilder.Run(async c =>
                    {
                        c.Response.StatusCode = 500;
                        await c.Response.WriteAsync("Something went horribly wrong");
                    });
                });
            }
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ECommerce");
            });
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
