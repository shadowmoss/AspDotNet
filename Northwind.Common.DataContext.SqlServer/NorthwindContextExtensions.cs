using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Packt.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Common.DataContext.SqlServer
{
    public static class NorthwindContextExtensions
    {
        public static IServiceCollection AddNorthwindContext(this IServiceCollection services,string connectionString = "\"Data Source=tcp:192.168.191.129,1433;Initial Catalog=Northwind;User ID=sa;Password=12345678~Ltx;Multiple Active Result Sets=True;Trust Server Certificate=True;") {
            services.AddDbContext<NorthwindContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
    }
}
