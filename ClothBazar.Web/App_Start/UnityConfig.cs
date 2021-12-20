using ClothBazar.Business;
using ClothBazar.Business.Interfaces;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace ClothBazar.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            //Mapping Interface <-> Service at runtime (Dependency Registeration)
            //=========================================
            //Categories
            container.RegisterType<ICategoryService, CategoryService>();
            //Products
            container.RegisterType<IProductService, ProductService>();
        }
    }
}