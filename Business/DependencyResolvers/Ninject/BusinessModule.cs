using System.Dynamic;
using System.Reflection;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ITaskService>().To<TaskManager>().InSingletonScope();
            Bind<ITaskDal>().To<EfTaskDal>().InSingletonScope();

            Bind<IPriorityService>().To<PriorityManager>().InSingletonScope();
            Bind<IPriorityDal>().To<EfPriorityDal>().InSingletonScope();

            Bind<IStatusService>().To<StatusManager>().InSingletonScope();
            Bind<IStatusDal>().To<EfStatusDal>().InSingletonScope();


        }
    }
}