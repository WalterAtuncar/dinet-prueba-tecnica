using BussinesLogic.product;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddBussinesLogicServices(this IServiceCollection services)
        {
            services.AddTransient<IProductLogic, ProductLogic>();
            return services;
        }
    }
}
