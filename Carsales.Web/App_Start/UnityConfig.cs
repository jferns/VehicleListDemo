//using System.Reflection;
//using System.Web.Mvc;
//using FIP.Common;
//using FIP.Common.DependencyInjection;
//using Microsoft.Practices.Unity;
//using Unity.Mvc5;

//namespace Carsales.Web
//{
//    public static class UnityConfig
//    {
//        public static void RegisterComponents()
//        {
//            ObjectFactory.Configure(Assembly.GetExecutingAssembly());

//            DependencyResolver.SetResolver(new UnityDependencyResolver(ObjectFactory.Container));
//        }
//    }
//}