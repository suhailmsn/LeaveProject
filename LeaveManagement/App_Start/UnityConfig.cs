using System;
using Unity;
using LeaveManagement.ServiceLayer;
using Unity.AspNet.Mvc;
using System.Web.Mvc;
using LeaveManagement.ServiceLayer.Interfaces;
using LeaveManagement.Repository.Interfaces;
using LeaveManagement.Repositories;
using Unity.Injection;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LeaveManagement
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

       
        public static void RegisterTypes(IUnityContainer container)

        {
            container.RegisterType(typeof(IUserStore<>), typeof(UserStore<>));
            container.RegisterType<LeaveManagementDbContext>();
            container.RegisterType<ApplicationSignInManager>();
            container.RegisterType<ApplicationUserManager>();


            container.RegisterType<IHRService, HRService>();
            container.RegisterType<IEmployeeService, EmployeeService>();
            container.RegisterType<IPMService, PMService>();
            container.RegisterType<IHRRepository, HRRepository>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<IPMRepository, PMRepository>();


        }
    }
}