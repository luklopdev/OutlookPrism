using OutlookPrism.Core;
using OutlookPrism.Modules.Mail.Menus;
using OutlookPrism.Modules.Mail.ViewModels;
using OutlookPrism.Modules.Mail.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;

namespace OutlookPrism.Modules.Mail
{
    public class MailModule : IModule
    {
        private readonly IRegionManager regionManager;

        public MailModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            regionManager.RegisterViewWithRegion(RegionNames.OutlookGroupRegion, typeof(MailGroup));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<MailGroup, MailGroupViewModel>();
            containerRegistry.RegisterForNavigation<MailList, MailListViewModel>();
        }
    }
}