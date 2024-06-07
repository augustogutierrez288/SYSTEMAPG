using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SYSTEMAPG.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
//using SYSTEMAPG.BLL.Implementation;
//using SYSTEMAPG.BLL.Interfaces;
//using SYSTEMAPG.DAL.Impletation;
//using SYSTEMAPG.DAL.Interfaces;

namespace SYSTEMAPG.IOC
{
    public static class Dependencia
    {
        public static void DependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SYSTEMAPGContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Connection"));
            });
        }
    }
}
