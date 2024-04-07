using System.Web.Mvc;
using CurdwithMVC.Data;
using CurdwithMVC.Repository;
using CurdwithMVC.Service;
using Unity;
using Unity.Mvc5;

namespace CurdwithMVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
             container.RegisterType<IDataFatory, DataFatory>();
             container.RegisterType<IUserRepository,  UserRepository >();
             container.RegisterType<IUserService, UserService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}