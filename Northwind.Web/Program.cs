namespace Northwind.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var builder = WebApplication.CreateBuilder(args);
            //var app = builder.Build();

            //if (!app.Environment.IsDevelopment()) {
            //    app.UseHsts();
            //}

            //app.UseHttpsRedirection();
            //app.MapGet("/", () => "Hello World!");

            //app.Run();

            //Console.WriteLine("This executes after the web server has stopped!");

            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            }).Build().Run();

            Console.WriteLine("This executes after the web server has stopped!");
        }
    }
}
