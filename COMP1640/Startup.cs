using COMP1640.Data;
using COMP1640.Models;
using COMP1640.Repository;
using COMP1640.Repository.IRepository;
using COMP1640.ViewModels.Response;
using COMP1640.ViewModels;

using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP1640
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddControllersWithViews()
                 .AddNewtonsoftJson(options =>
                     options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                 );
            services.AddSession();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireAdmin", policy =>
                    policy.RequireRole(Utils.Role.Admin));

                options.AddPolicy("RequireManager", policy =>
                   policy.RequireRole(Utils.Role.Manager));


                options.AddPolicy("RequireStaff", policy =>
                   policy.RequireRole(Utils.Role.Staff));


                options.AddPolicy("RequireCoordinator", policy =>
                   policy.RequireRole(Utils.Role.Coordinator));
            });





            services.AddIdentity<AppUserModel, RoleModel>()
                          .AddDefaultUI()
                          .AddEntityFrameworkStores<ApplicationDbContext>()
                                          .AddDefaultTokenProviders();

            services.AddControllersWithViews();



            services.AddScoped<ICategoriesRepository, CategoriesRepository>();
            services.AddScoped<IUsersRepository,UsersRepository>();





            services.AddTransient<ISendEmail, SendEmail>();
            services.Configure<EmailSenderOptions>(options =>
            {
                options.Host = Configuration["MailSettings:Host"];
                options.Port = int.Parse(Configuration["MailSettings:Port"]);
                options.User = Configuration["MailSettings:User"];
                options.Pass = Configuration["MailSettings:Pass"];
                options.Name = Configuration["MailSettings:Name"];
                options.Sender = Configuration["MailSettings:User"];
            });


            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "Cookie";
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(720);
                options.LoginPath = new PathString("/Login");
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.SlidingExpiration = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            { 
                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{area=Unauthenticated}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            
        }
    }
}
