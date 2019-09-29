using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NationalDay_DDD.Infrastruct.Data.Context;
using NationalDay_DDD.WebApp.Extensions;

namespace NationalDay_DDD.WebApp
{
    public class Startup
    {
        /*
        һ��Ǩ����Ŀ1��һ��Ҫ�л��� Christ3D.Infrastruct ��Ŀ�£�ʹ�� Package Manager Console����
        1��add-migration InitStudentDb -Context StudyContext 
        2��add-migration InitEventStoreDb -Context EventStoreSQLContext -o Migrations/EventStore
        3��update-database -Context StudyContext
        4��update-database -Context EventStoreSQLContext

        ����Ǩ����Ŀ2��һ��Ҫ�л��� Christ3D.Infrastruct.Identity ��Ŀ�£�ʹ�� Package Manager Console����
        1��add-migration InitIdentityDb -Context ApplicationDbContext -o Data/Migrations/ 
        2��update-database -Context ApplicationDbContext
        */

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            // .NET Core ԭ������ע��
            // ��дһ����������������չʾ�� Presentation �и���
            NativeInjectorBootStrapper.RegisterServices(services);
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
