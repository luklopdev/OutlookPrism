using OutlookPrism.Core;
using OutlookPrism.Modules.Contacts.Menus;
using OutlookPrism.Modules.Contacts.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace OutlookPrism.Modules.Contacts
{
    public class ContactsModule : IModule
    {
        private readonly IRegionManager regionManager;

        public ContactsModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            regionManager.RegisterViewWithRegion(RegionNames.OutlookGroupRegion, typeof(ContactsGroup));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}