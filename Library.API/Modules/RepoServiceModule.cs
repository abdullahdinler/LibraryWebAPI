using System.Reflection;
using Autofac;
using Library.Core.Repositories;
using Library.Repository.Repositories;
using Library.Service.Services;
using Library.Core.Services;
using Library.Core.UnitOfWorks;
using Library.Repository.Context;
using Library.Repository.UnitOfWorks;
using Module = Autofac.Module;

namespace Library.API.Modules
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>))
                .InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<,>)).As(typeof(IService<,>)).InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();

            var apiAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(LibraryDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(AddressService));

            builder.RegisterAssemblyTypes(apiAssembly,repoAssembly,serviceAssembly).Where(x=>x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
