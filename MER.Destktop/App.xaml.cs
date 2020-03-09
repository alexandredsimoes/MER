using Prism.Ioc;
using MER.Destktop.Views;
using System.Windows;
using Prism.Regions;

namespace MER.Destktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            var regionManager = this.Container.Resolve<IRegionManager>();
            regionManager.RequestNavigate("ContentRegion", "Result");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Result>();
        }
    }
}
