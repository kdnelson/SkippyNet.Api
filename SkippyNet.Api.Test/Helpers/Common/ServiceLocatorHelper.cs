using SkippyNet.Api.Test.Controllers;
using SkippyNet.Api.Test.Helpers.Work;
using SkippyNet.Api.Test.Interfaces.Common;
using SkippyNet.Api.Test.Interfaces.Work;
using SkippyNet.Api.Test.Tests.Work;
using Unity;

namespace Dinerware.Api.Test.Helpers.Common
{
    public class ServiceLocatorHelper
    {
        private static IUnityContainer _container;

        public static IUnityContainer Initialize()
        {
            BuildUnityContainer();
            return _container;
        }

        private static void BuildUnityContainer()
        {
            _container = new UnityContainer();

            // Common
            _container.RegisterType<ITestController, TestController>();
            _container.RegisterType<IRequestHelper, RequestHelper>();
            _container.RegisterType<IUrlHelper, UrlHelper>();

            // Work
            _container.RegisterType<IWorkTestController, WorkTestController>();
            _container.RegisterType<IWorkRequestHelper, WorkRequestHelper>();
            _container.RegisterType<IWorkCreateFixture, WorkCreateFixture>();
            _container.RegisterType<IWorkDeleteFixture, WorkDeleteFixture>();
            _container.RegisterType<IWorkGetFixture, WorkGetFixture>();
            _container.RegisterType<IWorkSearchFixture, WorkSearchFixture>();
            _container.RegisterType<IWorkUpdateFixture, WorkUpdateFixture>();
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
