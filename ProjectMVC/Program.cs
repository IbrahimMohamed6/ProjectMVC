namespace ProjectMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            app.UseStaticFiles();
            app.UseRouting();

            #region MyRegion
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("You Are At Home Page");
            //    });
            //});




            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Products", async context =>
            //    {
            //        await context.Response.WriteAsync("You Are At Products Page");
            //    });
            //});

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Products/{id}", async context =>
            //    {
            //        int id =Convert.ToInt32( context.Request.RouteValues["id"]);
            //        await context.Response.WriteAsync($"You Are At Products Page Wih id => {id}");
            //    });
            //}); 
            #endregion


            app.MapControllerRoute(
                name: "defualt",
                pattern: "/{controller=Home}/{Action=Index}",
                defaults: new { controller = "Home", Action = "Index"}
                );

            app.Run();


            
        }
    }
}
