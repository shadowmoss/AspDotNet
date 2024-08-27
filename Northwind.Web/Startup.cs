namespace Northwind.Web
{
    public class Startup
    {
        // 向依赖注入容器中添加依赖服务
        public void ConfigureServices(IServiceCollection services) { 
            services.AddRazorPages();
        }
        // 配置Http通信管道
        public void Configure(IApplicationBuilder app,IWebHostEnvironment env) {
            if (!env.IsDevelopment()) {
                app.UseHsts();
            }

            // 启用端点路由
            app.UseRouting();

            app.UseHttpsRedirection();

            // index.html,defualt.html,启用默认文件
            app.UseDefaultFiles();

            // 启用静态文件
            app.UseStaticFiles();

            // 设置端点路由内容
            app.UseEndpoints(endpoints => {
                endpoints.MapRazorPages();
                endpoints.MapGet("/hello",() => "Test Hello World!");
            });
        }
    }
}
