using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
 namespace Z.Service
{
    partial class Startup
    {
      
   

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
 
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IGadgetService, GadgetService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
     }
}
