namespace MVCWebApplication1
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
            if (!app.Environment.IsDevelopment()) //kda mazbota tzhar ll users msh ll developers
            {
                app.UseExceptionHandler("/Home/Error"); // el error method in hme contoller which will direct it to error view in shared views folder
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            //Manipulating URL segments
            app.MapControllerRoute(
                name: "rule1",
                pattern: "Wheather/{Country}/{City}",
                defaults: new
                {
                    Controller = "Wheather",
                    action = "GetWheather"
                });

            app.MapControllerRoute(
                name: "rule2",
                pattern: "Degree",
                defaults: new
                {
                    Controller = "Wheather",
                    action = "GetWheather"
                });

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}