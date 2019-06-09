using PI_Service;
using PI_Service.ImplementationsBD;
using PI_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace PI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<F_Author>());
        }

        public static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();

            currentContainer.RegisterType<DbContext, PiDbContext>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ISizeService, SizeServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ITypemyService, TypemyServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IMaterialService, MaterialServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IBuyService, BuyServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IMainService, MainServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IUserService, UserServiceBD>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IOrderService, OrderServiceBD>(new HierarchicalLifetimeManager());

            currentContainer
       .RegisterType<F_Author>()
       .RegisterInstance<IUnityContainer>(currentContainer);

            return currentContainer;
        }
    }
}
