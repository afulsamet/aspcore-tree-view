namespace TreeView
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;

    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection Services)
        {
            Services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder App, IWebHostEnvironment Environment)
        {
            if (Environment.IsDevelopment())
                App.UseDeveloperExceptionPage();
            else
            {
                App.UseExceptionHandler("/Home/Error");
                App.UseHsts();
            }

            App.UseStaticFiles();

            App.UseRouting();

            App.UseAuthorization();

            App.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
