using System.Windows;
using Prism.Ioc;
using Prism.DryIoc;
using CIM_Client.Views;
using System.Reflection;

namespace CIM_Client
{
    class Bootstrapper : PrismBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // 扫描接口层程序集中的类型
            var interfaceAssembly = Assembly.Load("CIM.Servers");
            var serviceTypes = interfaceAssembly.GetExportedTypes().Where(i => i.IsClass || i.Name.EndsWith("Servers")).ToList();

            // 注册服务
            foreach (var serviceType in serviceTypes)
            {
                containerRegistry.Register(serviceType.GetInterface("I" + serviceType.Name), serviceType);
            }
        }
    }
}
