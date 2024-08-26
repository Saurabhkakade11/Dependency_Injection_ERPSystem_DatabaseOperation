using ERPSystem_DatabaseServices.Implementations;
using ERPSystem_DatabaseServices.Implementationsz;
using ERPSystem_DatabaseServices.Interfaces;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace ERPSystem_WebApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();




            container.RegisterType(typeof(IRepository<>), typeof(Repository<>));
            container.RegisterType<ITopicService, TopicService>();
            container.RegisterType<ITopicContentService, TopicContentService>();
            container.RegisterType<ICourseServices, CourseServices>();




            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}