using DDDSkeleton.Application;
using DDDSkeleton.Application.Interface;
using DDDSkeleton.Domain.Interfaces;
using DDDSkeleton.Domain.Interfaces.Services;
using DDDSkeleton.Domain.Services;
using DDDSkeleton.Infra.Data.Context;
using DDDSkeleton.Infra.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ninject;

namespace DDDSkeleton.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BaseContext>(options =>
            {
                options.UseInMemoryDatabase("database");
            });

            AutoMapper.AutoMapperConfig.RegisterMappings();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }


        // Independecy Injection Builder
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IItemAppService>().To<ItemAppService>();
            kernel.Bind<IItemListAppService>().To<ItemListAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IItemService>().To<ItemService>(); ;
            kernel.Bind<IItemListService>().To<ItemListService>();

            kernel.Bind(typeof(IBaseRepository<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IItemRepository>().To<ItemRepository>();
            kernel.Bind<IItemListRepository>().To<ItemListRepository>();
        }

    }
}
