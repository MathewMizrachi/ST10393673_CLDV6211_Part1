namespace ST10393673_CLDV6211_Part1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            
            app.MapControllerRoute(
                name: "MyWork",
                pattern: "MyWork",
                defaults: new { controller = "Home", action = "MyWork" });

            app.MapControllerRoute(
                name: "AboutUs",
                pattern: "AboutUs",
                defaults: new { controller = "Home", action = "AboutUs" });

            app.MapControllerRoute(
                name: "ContactUs",
                pattern: "ContactUs",
                defaults: new { controller = "Home", action = "ContactUs" });

            app.MapControllerRoute(
                name: "Login",
                pattern: "Login",
                defaults: new { controller = "Home", action = "Login" });


            app.Run();
        }
    }
}
